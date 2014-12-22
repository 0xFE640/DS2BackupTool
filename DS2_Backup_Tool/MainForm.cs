namespace DS2_Backup_Tool
{
    using System;
    using System.Windows.Forms;
    using System.IO;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var save_path = @"C:\temp";
            string[] files = Directory.GetFiles(save_path);
            listBox1.Items.Clear();
            var fileName = Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)),"Test","Temp","file1.txt");
            //MessageBox.Show(fileName);
            File.Copy(fileName, @"C:\temp\copied3.txt" + files.Length);
            foreach (string s in Directory.GetFiles(save_path))
                listBox1.Items.Add(Path.GetFileName(s)+"     "+File.GetLastWriteTime(s));
        }
    }
}
