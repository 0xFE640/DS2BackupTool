﻿namespace DS2_Backup_Tool
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstSaves = new System.Windows.Forms.ListBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtSavesPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.btnBrowseSaves = new System.Windows.Forms.Button();
            this.btnBrowseBackups = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSaves
            // 
            this.lstSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstSaves.FormattingEnabled = true;
            this.lstSaves.ItemHeight = 16;
            this.lstSaves.Location = new System.Drawing.Point(12, 21);
            this.lstSaves.Name = "lstSaves";
            this.lstSaves.Size = new System.Drawing.Size(539, 260);
            this.lstSaves.TabIndex = 5;
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(557, 60);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(91, 33);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load F8";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButtonClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(557, 99);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 33);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // BackupButton
            // 
            this.BackupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackupButton.Location = new System.Drawing.Point(557, 21);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(91, 33);
            this.BackupButton.TabIndex = 8;
            this.BackupButton.Text = "Backup F5";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButtonClick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Dark Souls  2 Back Saves";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // txtSavesPath
            // 
            this.txtSavesPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSavesPath.Location = new System.Drawing.Point(113, 302);
            this.txtSavesPath.Name = "txtSavesPath";
            this.txtSavesPath.Size = new System.Drawing.Size(438, 21);
            this.txtSavesPath.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "DS2 Saves Path";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBackupPath.Location = new System.Drawing.Point(113, 330);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(438, 21);
            this.txtBackupPath.TabIndex = 13;
            this.txtBackupPath.Text = "C:\\temp";
            // 
            // btnBrowseSaves
            // 
            this.btnBrowseSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseSaves.Location = new System.Drawing.Point(557, 302);
            this.btnBrowseSaves.Name = "btnBrowseSaves";
            this.btnBrowseSaves.Size = new System.Drawing.Size(91, 23);
            this.btnBrowseSaves.TabIndex = 15;
            this.btnBrowseSaves.Text = "Browse";
            this.btnBrowseSaves.UseVisualStyleBackColor = true;
            this.btnBrowseSaves.Click += new System.EventHandler(this.BrowseSavesButtonClick);
            // 
            // btnBrowseBackups
            // 
            this.btnBrowseBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseBackups.Location = new System.Drawing.Point(557, 333);
            this.btnBrowseBackups.Name = "btnBrowseBackups";
            this.btnBrowseBackups.Size = new System.Drawing.Size(91, 23);
            this.btnBrowseBackups.TabIndex = 16;
            this.btnBrowseBackups.Text = "Browse";
            this.btnBrowseBackups.UseVisualStyleBackColor = true;
            this.btnBrowseBackups.Click += new System.EventHandler(this.BrowseBackupsButtonClick);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.LocalApplicationData;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Backup Path";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 367);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(666, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.Color.Green;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(33, 17);
            this.statusLabel.Text = "Info";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Dark Souls 2 saves  (*.sl2)| *.sl2";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(666, 389);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseBackups);
            this.Controls.Add(this.btnBrowseSaves);
            this.Controls.Add(this.txtBackupPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSavesPath);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.lstSaves);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DS2 Backup Tool";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstSaves;
        private Button LoadButton;
        private Button DeleteButton;
        private Button BackupButton;
        private NotifyIcon notifyIcon;
        private TextBox txtSavesPath;
        private Label label3;
        private TextBox txtBackupPath;
        private Button btnBrowseSaves;
        private Button btnBrowseBackups;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private OpenFileDialog openFileDialog1;
    }
}

