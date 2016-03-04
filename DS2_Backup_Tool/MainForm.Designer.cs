namespace DS2_Backup_Tool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDS2SOTFS = new System.Windows.Forms.RadioButton();
            this.radioButtonDS2Orig = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifiedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(557, 60);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(128, 33);
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
            this.DeleteButton.Size = new System.Drawing.Size(128, 33);
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
            this.BackupButton.Size = new System.Drawing.Size(128, 33);
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
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TrayIconClick);
            // 
            // txtSavesPath
            // 
            this.txtSavesPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSavesPath.Location = new System.Drawing.Point(113, 431);
            this.txtSavesPath.Name = "txtSavesPath";
            this.txtSavesPath.Size = new System.Drawing.Size(438, 21);
            this.txtSavesPath.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "DS2 Saves Path";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBackupPath.Location = new System.Drawing.Point(113, 459);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(438, 21);
            this.txtBackupPath.TabIndex = 13;
            this.txtBackupPath.Text = "C:\\temp";
            // 
            // btnBrowseSaves
            // 
            this.btnBrowseSaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseSaves.Location = new System.Drawing.Point(557, 431);
            this.btnBrowseSaves.Name = "btnBrowseSaves";
            this.btnBrowseSaves.Size = new System.Drawing.Size(128, 23);
            this.btnBrowseSaves.TabIndex = 15;
            this.btnBrowseSaves.Text = "Browse";
            this.btnBrowseSaves.UseVisualStyleBackColor = true;
            this.btnBrowseSaves.Click += new System.EventHandler(this.BrowseSavesButtonClick);
            // 
            // btnBrowseBackups
            // 
            this.btnBrowseBackups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBrowseBackups.Location = new System.Drawing.Point(557, 462);
            this.btnBrowseBackups.Name = "btnBrowseBackups";
            this.btnBrowseBackups.Size = new System.Drawing.Size(128, 23);
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
            this.label4.Location = new System.Drawing.Point(12, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Backup Path";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 495);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(698, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDS2SOTFS);
            this.groupBox1.Controls.Add(this.radioButtonDS2Orig);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(557, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 87);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Version";
            // 
            // radioButtonDS2SOTFS
            // 
            this.radioButtonDS2SOTFS.AutoSize = true;
            this.radioButtonDS2SOTFS.Location = new System.Drawing.Point(6, 47);
            this.radioButtonDS2SOTFS.Name = "radioButtonDS2SOTFS";
            this.radioButtonDS2SOTFS.Size = new System.Drawing.Size(100, 20);
            this.radioButtonDS2SOTFS.TabIndex = 0;
            this.radioButtonDS2SOTFS.Text = "DS2 SOTFS";
            this.radioButtonDS2SOTFS.UseVisualStyleBackColor = true;
            // 
            // radioButtonDS2Orig
            // 
            this.radioButtonDS2Orig.AutoSize = true;
            this.radioButtonDS2Orig.Checked = true;
            this.radioButtonDS2Orig.Location = new System.Drawing.Point(6, 21);
            this.radioButtonDS2Orig.Name = "radioButtonDS2Orig";
            this.radioButtonDS2Orig.Size = new System.Drawing.Size(101, 20);
            this.radioButtonDS2Orig.TabIndex = 0;
            this.radioButtonDS2Orig.TabStop = true;
            this.radioButtonDS2Orig.Text = "DS2 Original";
            this.radioButtonDS2Orig.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(557, 231);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 22);
            this.numericUpDown1.TabIndex = 20;
            // 
            // DGView
            // 
            this.DGView.AllowUserToAddRows = false;
            this.DGView.AllowUserToDeleteRows = false;
            this.DGView.AllowUserToResizeColumns = false;
            this.DGView.AllowUserToResizeRows = false;
            this.DGView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Version,
            this.CreateTime,
            this.ModifiedTime});
            this.DGView.Location = new System.Drawing.Point(15, 21);
            this.DGView.MultiSelect = false;
            this.DGView.Name = "DGView";
            this.DGView.ReadOnly = true;
            this.DGView.RowHeadersVisible = false;
            this.DGView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGView.Size = new System.Drawing.Size(536, 404);
            this.DGView.TabIndex = 21;
            // 
            // Version
            // 
            this.Version.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Version.FillWeight = 76.14214F;
            this.Version.HeaderText = "Version";
            this.Version.Name = "Version";
            this.Version.ReadOnly = true;
            this.Version.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Version.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Version.Width = 67;
            // 
            // CreateTime
            // 
            this.CreateTime.FillWeight = 111.9289F;
            this.CreateTime.HeaderText = "CreateTime";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ModifiedTime
            // 
            this.ModifiedTime.FillWeight = 111.9289F;
            this.ModifiedTime.HeaderText = "ModifiedTime";
            this.ModifiedTime.Name = "ModifiedTime";
            this.ModifiedTime.ReadOnly = true;
            this.ModifiedTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(698, 517);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.groupBox1);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DS2 Backup Tool";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private GroupBox groupBox1;
        private RadioButton radioButtonDS2SOTFS;
        private RadioButton radioButtonDS2Orig;
        private NumericUpDown numericUpDown1;
        private DataGridView DGView;
        private DataGridViewTextBoxColumn Version;
        private DataGridViewTextBoxColumn CreateTime;
        private DataGridViewTextBoxColumn ModifiedTime;
    }
}

