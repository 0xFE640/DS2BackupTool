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

        private readonly KeyboardHook hook = new KeyboardHook();

        private readonly SoundPlayer simpleSound;

        public MainForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            dic = new Dictionary<int, string>();
            simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
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
            foreach (var s in Directory.GetFiles(save_path))
            {
                listBox1.Items.Add(Path.GetFileName(s) + "    " + File.GetLastWriteTime(s));
                if (listBox1.Items.Count - 1 >= 0)
                    dic.Add(listBox1.Items.Count - 1, s);
            }
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void BackupSave()
        {
            Directory.GetFiles(save_path);
            File.Copy(fileName, @"C:\temp\DARKSII0000.sl2" + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss.f"));
            showFiles();
            label2.Text = @"The save was backed up";
        }

        private void LoadSave()
        {
            var count = listBox1.Items.Count;
            if (count > 0)
            {
                File.Copy(dic[listBox1.SelectedIndex], fileName, true);
                listBox1.SelectedIndex = count - 1;
                label2.Text = @"Save is restored  " + dic[listBox1.SelectedIndex];
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
            if (listBox1.Items.Count > 0)
            {
                File.Delete(dic[listBox1.SelectedIndex]);
                listBox1.Items.Clear();
                showFiles();
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            showFiles();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }
    }
}