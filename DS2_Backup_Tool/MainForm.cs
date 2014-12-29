namespace DS2_Backup_Tool
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Media;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private const string save_path = @"C:\temp";

        private readonly Dictionary<int, string> dic;

        private readonly string fileName =
            Path.Combine(
                (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),
                "DarkSoulsII",
                "0110000102ee03bd",
                "DARKSII0000.sl2");
        private readonly string fileNameDS1 = @"f:\Win8Docs\NBGI\DarkSouls\OvertOrange9272\DRAKS0005.sl2";
           
        private readonly KeyboardHook hook = new KeyboardHook();

        private readonly SoundPlayer simpleSound;

        public MainForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            dic = new Dictionary<int, string>();
            simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            openFileDialog1.InitialDirectory = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),"DarkSoulsII");
            hook.KeyPressed += HookKeyPressed;
            hook.RegisterHotKey(new ModifierKeys(), Keys.F5);
            hook.RegisterHotKey(new ModifierKeys(), Keys.F8);
        }

        private void HookKeyPressed(object sender, KeyPressedEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.F5:
                    BackupSave();
                    break;
                case Keys.F8:
                 //   LoadSave();
                    break;
            }
        }

        private void showFiles()
        {
            savesListBox.Items.Clear();
            dic.Clear();
            foreach (var s in Directory.GetFiles(save_path))
            {
                savesListBox.Items.Add(Path.GetFileName(s) + "    " + File.GetLastWriteTime(s));
                if (savesListBox.Items.Count - 1 >= 0)
                    dic.Add(savesListBox.Items.Count - 1, s);
            }
            savesListBox.SelectedIndex = savesListBox.Items.Count - 1;
        }

        private void BackupSave()
        {
            Directory.GetFiles(save_path);
            if (DS2radioButton.Checked)
                File.Copy(fileName, @"C:\temp\DARKSII0000.sl2" + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss.f"));

            if (DS1radioButton.Checked)
            {
                File.Copy(fileNameDS1, @"E:\temp\DS\DRAKS0005.sl2" + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss.f"));
                simpleSound.Play();
            }

            if (DS2radioButton.Checked)
            {
                showFiles();
                statusLabel.Text = @"The save was backed up";
            }
            

            
           // label2.Text = @"The save was backed up";
            
        }

        private void LoadSave()
        {
            var count = savesListBox.Items.Count;
            if (count > 0)
            {
                File.Copy(dic[savesListBox.SelectedIndex], fileName, true);
                savesListBox.SelectedIndex = count - 1;
                //label2.Text = @"Save is restored  " + dic[savesListBox.SelectedIndex];
                statusLabel.Text = @"Save is restored  " + dic[savesListBox.SelectedIndex];
                simpleSound.Play();
            }
            else
            {
                MessageBox.Show(@"Backups not found");
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
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

        private void loadButtonClick(object sender, EventArgs e)
        {
            //   MessageBox.Show(DateTime.Now.ToString("yyyy-MM-dd_HH:mm:ss"));
            LoadSave();
        }

        private void backupButtonClick(object sender, EventArgs e)
        {
            BackupSave();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            //   foreach (string s in Directory.GetFiles(save_path))
            if (savesListBox.Items.Count > 0)
            {
                File.Delete(dic[savesListBox.SelectedIndex]);
                savesListBox.Items.Clear();
                showFiles();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            showFiles();
            savesListBox.SelectedIndex = savesListBox.Items.Count - 1;
            textBox1.Text = fileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBox2.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}