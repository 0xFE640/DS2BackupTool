namespace DS2_Backup_Tool
{
    using System;
    using System.Windows.Forms;
    using System.IO;
    using System.Collections.Generic;

    public partial class MainForm : Form
    {
        string save_path = @"C:\temp";
        Dictionary<int, string> dic;
        public MainForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            dic = new Dictionary<int, string>();

        }

        public void showFiles()
        {
            listBox1.Items.Clear();
            
            foreach (string s in Directory.GetFiles(save_path))
            {
                listBox1.Items.Add(Path.GetFileName(s) + "     " + File.GetLastWriteTime(s));
                if (listBox1.Items.Count - 1 >= 0)
                    dic.Add(listBox1.Items.Count-1, s);
            }
            
        }


        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void loadButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show(dic[listBox1.SelectedIndex]);
        }

        private void backupButtonClick(object sender, EventArgs e)
        {
           
            string[] files = Directory.GetFiles(save_path);
        //    listBox1.Items.Clear();
            var fileName = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), "Test", "Temp", "file1.txt");
            //MessageBox.Show(fileName);
            File.Copy(fileName, @"C:\temp\copied.txt"+"_" + files.Length);
            
            showFiles();
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            foreach (string s in Directory.GetFiles(save_path))
                File.Delete(s);
            listBox1.Items.Clear();
            showFiles();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
          //  showFiles();
        }
    }
}
