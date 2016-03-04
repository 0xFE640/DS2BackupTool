namespace DS2_Backup_Tool
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Media;
    using System.Windows.Forms;
    


    public partial class MainForm : Form
    {
        
        //TODO: Remove global variables

        private readonly string BackupsPath;
        string fileVersion; 
        string idFolder;
        private readonly Dictionary<int, string> dic;
        private readonly KeyboardHook hook = new KeyboardHook();
        private readonly SoundPlayer simpleSound;


         
        public MainForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            dic = new Dictionary<int, string>();
            BackupsPath = txtBackupPath.Text+"\\";
            simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            openFileDialog1.InitialDirectory = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),"DarkSoulsII");
            hook.KeyPressed += HookKeyPressed;
            hook.RegisterHotKey(Keys.F5, new ModifierKey());
            hook.RegisterHotKey(Keys.F8, new ModifierKey());
            hook.RegisterHotKey(Keys.Delete, new ModifierKey());

        }


        private string GetSavesLocation()
        {
            const string ds2s = "DS2SOFS0000.sl2";
            const string ds2o = "DARKSII0000.sl2";


            if (radioButtonDS2Orig.Checked)
                fileVersion = ds2o;
            if (radioButtonDS2SOTFS.Checked)
                fileVersion = ds2s;

            idFolder = Directory.GetDirectories(Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), "DarkSoulsII"))[0];

            return Path.Combine(idFolder, fileVersion);
        }
                    
        private void HookKeyPressed(object sender, KeyPressedEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.F5:
                    BackupSave();
                    break;
                case Keys.F8:
                    LoadSave();
                    break;
                case Keys.Delete:
                    DeleteButton.PerformClick();
                    break;
            }
        }

        private void UpdateList()
        {
            //string ds2version="";
            //if (radioButtonDS2Orig.Checked)
            //    ds2version = "Dark Souls 2";
            //if (radioButtonDS2SOTFS.Checked)
            //    ds2version = "Dark Souls 2 SOTFS";
            string version = "";

            DGView.Rows.Clear();
            dic.Clear();
            foreach (var file in Directory.GetFiles(BackupsPath))
            {

                if (Path.GetFileName(file).Contains("SOFS"))
                    version = "Dark Souls 2 SOTFS";
                else
                    version = "Dark Souls 2";

                DGView.Rows.Add(version,File.GetCreationTime(file), File.GetLastWriteTime(file));
                if (DGView.Rows.Count-1 >=0)
                    dic.Add(DGView.Rows.Count - 1, file);
            }

            if (DGView.Rows.Count >= 0)
                DGView.Rows[DGView.Rows.Count - 1].Cells[0].Selected = true;
            

        }

        private void BackupSave()
        {
           // Directory.GetFiles(BackupsPath);
            try
            {
                File.Copy(GetSavesLocation(), BackupsPath + Path.GetFileName(GetSavesLocation())
                    + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss,f") /* +"DARKSII0000.sl2"*/ );
                statusLabel.Text = @"The save was backed up";
            }
            catch (IOException ioException)
            {
                MessageBox.Show(ioException.Message);
            }
            UpdateList();
           
        }

        private void LoadSave()
        {
            if (!File.Exists(GetSavesLocation()))
            {
                MessageBox.Show("Path " + GetSavesLocation() + " doesn't exist");
                return;
            }
            var count = DGView.Rows.Count;

            if (count > 0)
            {
                File.Copy(dic[DGView.CurrentCell.RowIndex], GetSavesLocation(), true);
                DGView.Rows[DGView.Rows.Count-1].Selected = true;
                //label2.Text = @"Save is restored  " + dic[savesListBox.SelectedIndex];
               // statusLabel.Text = @"Save is restored  " + dic[lstSaves.SelectedIndex];
                simpleSound.Play();
            }
            else
            {
                MessageBox.Show(@"Backups not found in "+ BackupsPath);
            }
        }

        private void TrayIconClick(object sender, MouseEventArgs e)
        {
            Show();
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void LoadButtonClick(object sender, EventArgs e)
        {
            LoadSave();
        }

        private void BackupButtonClick(object sender, EventArgs e)
        {
            BackupSave();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            if (DGView.Rows.Count > 0)
            {
                File.Delete(dic[DGView.CurrentCell.RowIndex]);
                UpdateList();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            UpdateList();
            txtSavesPath.Text = GetSavesLocation();
        }

        private void BrowseSavesButtonClick(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtSavesPath.Text = openFileDialog1.FileName;
        }

        private void BrowseBackupsButtonClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                txtBackupPath.Text = folderBrowserDialog1.SelectedPath;
        }

       
    }
}
