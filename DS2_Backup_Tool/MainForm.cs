namespace DS2_Backup_Tool
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Collections.Generic;

    public partial class MainForm : Form
    {
        private readonly KeyboardHook hook = new KeyboardHook();
        string save_path = @"C:\temp";
        readonly  string fileName = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),
              "DarkSoulsII", "0110000102ee03bd", "DARKSII0000.sl2");
        Dictionary<int, string> dic;
        public MainForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            dic = new Dictionary<int, string>();
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
                    LoadSave();
                    break;
            }
        }


        private void showFiles()
        {
            listBox1.Items.Clear();
            dic.Clear();
            foreach (string s in Directory.GetFiles(save_path))
            {
                listBox1.Items.Add(Path.GetFileName(s) + "    " + File.GetLastWriteTime(s));
                if (listBox1.Items.Count - 1 >= 0)
                    dic.Add(listBox1.Items.Count-1, s);
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            
        }
        private void BackupSave()
        {
            string[] files = Directory.GetFiles(save_path);
            File.Copy(fileName, @"C:\temp\DARKSII0000.sl2" + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss.f"));
            showFiles();

        }
        private void LoadSave()
        {
            File.Copy(dic[listBox1.SelectedIndex], fileName, true);
            listBox1.SelectedIndex = listBox1.Items.Count-1;

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            if (WindowState == FormWindowState.Minimized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Minimized;
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
            File.Delete(dic[listBox1.SelectedIndex]);
            listBox1.Items.Clear();
            showFiles();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            showFiles();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}
