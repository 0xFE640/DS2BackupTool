using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace DS2_Backup_Tool
{
  class Controller
    {
        private readonly string BackupsPath = @"C:\temp\";
        string vFileName;
        string idFolder;
        private readonly Dictionary<int, string> dic;
        private readonly KeyboardHook hook = new KeyboardHook();
        private readonly SoundPlayer simpleSound;

        public  enum DS2Vesrsion { DS2Orig, DS2SOTFS}
       


   public   Controller()
        {
            hook.KeyPressed += HookKeyPressed;
            hook.RegisterHotKey(Keys.F5, new ModifierKey());
            hook.RegisterHotKey(Keys.F8, new ModifierKey());
            hook.RegisterHotKey(Keys.Delete, new ModifierKey());
        }


        private void HookKeyPressed(object sender, KeyPressedEventArgs e)
        {
            switch (e.Key)
            {
                case Keys.F5:
                    BackupSave();
                    break;
                case Keys.F8:
                    //LoadSave();
                    break;
                case Keys.Delete:
                    //DeleteButton.PerformClick();
                    break;
            }
        }

        //private DS2Vesrsion GetVersion()
        //{
            
        //    return DS2Vesrsion.DS2Orig;

        //}

        private string GetSaveLocation(DS2Vesrsion ds2Ver)
        {
            const string ds2s = "DS2SOFS0000.sl2";
            const string ds2o = "DARKSII0000.sl2";

            if (ds2Ver == DS2Vesrsion.DS2Orig)
                vFileName = ds2o;
            else
                vFileName = ds2s;

            idFolder = Directory.GetDirectories(Path.Combine((Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)), "DarkSoulsII"))[0];

            return Path.Combine(idFolder, vFileName);
        }


        public void UpdateList(ListBox lstSaves)
        {
            lstSaves.Items.Clear();
            dic.Clear();
            foreach (var file in Directory.GetFiles(BackupsPath))
            {
                lstSaves.Items.Add(Path.GetFileName(file) + "    " + File.GetLastWriteTime(file));
                if (lstSaves.Items.Count - 1 >= 0)
                    dic.Add(lstSaves.Items.Count - 1, file);
            }
            lstSaves.SelectedIndex = lstSaves.Items.Count - 1;
        }

        private void BackupSave()
        {
            Directory.GetFiles(BackupsPath);
            try
            {
                //File.Copy(GetSavesPath(),BackupsPath +"DARKSII0000.sl2" + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss,f"));
                File.Copy(GetSaveLocation(DS2Vesrsion.DS2Orig), BackupsPath + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss,f") + " " + "DARKSII0000.sl2");
              //  statusLabel.Text = @"The save was backed up";
            }
            catch (IOException ioException)
            {
                MessageBox.Show(ioException.Message);
            }
            //ShowFiles();

        }

        //private void LoadSave(ListBox lstSaves)
        //{
        //    if (!File.Exists(GetSaveLocation()))
        //    {
        //        MessageBox.Show("Path " + GetSaveLocation() + " doesn't exist");
        //        return;
        //    }
        //    var count = lstSaves.Items.Count;
        //    if (count > 0)
        //    {
        //        File.Copy(dic[lstSaves.SelectedIndex], GetSavesLocation(), true);
        //        lstSaves.SelectedIndex = count - 1;
        //        //label2.Text = @"Save is restored  " + dic[savesListBox.SelectedIndex];
        //  //      statusLabel.Text = @"Save is restored  " + dic[lstSaves.SelectedIndex];
        //        simpleSound.Play();
        //    }
        //    else
        //    {
        //        MessageBox.Show(@"Backups not found in " + BackupsPath);
        //    }
        //}



    }
}
