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
            this.components = new Container();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            this.textBox1 = new TextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBox2 = new TextBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.listBox1 = new ListBox();
            this.button3 = new Button();
            this.button4 = new Button();
            this.button5 = new Button();
            this.folderBrowserDialog1 = new FolderBrowserDialog();
            this.notifyIcon1 = new NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(91, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(229, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "%appdata%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(9, 321);
            this.label1.Name = "label1";
            this.label1.Size = new Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Save Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(9, 355);
            this.label2.Name = "label2";
            this.label2.Size = new Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Backup Path";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(91, 352);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(229, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "C:\\temp\\";
            // 
            // button1
            // 
            this.button1.Location = new Point(352, 316);
            this.button1.Name = "button1";
            this.button1.Size = new Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new Point(352, 349);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "save1",
            "save2"});
            this.listBox1.Location = new Point(12, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(308, 212);
            this.listBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new Point(352, 127);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Load F8";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new Point(352, 172);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new Point(352, 86);
            this.button5.Name = "button5";
            this.button5.Size = new Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Backup F5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
       //     this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 390);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "DS2 Backup Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private FolderBrowserDialog folderBrowserDialog1;
        private NotifyIcon notifyIcon1;
    }
}

