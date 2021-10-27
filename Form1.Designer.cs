
namespace WFCourseWork
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.fileChooseBtn = new System.Windows.Forms.Button();
            this.fileBox = new System.Windows.Forms.GroupBox();
            this.checksumCompareBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checksumBox = new System.Windows.Forms.GroupBox();
            this.checksumSHA512Box = new System.Windows.Forms.TextBox();
            this.checksumSHA512 = new System.Windows.Forms.CheckBox();
            this.checksumSHA256Box = new System.Windows.Forms.TextBox();
            this.checksumSHA256 = new System.Windows.Forms.CheckBox();
            this.checksumSHA1 = new System.Windows.Forms.CheckBox();
            this.checksumSHA1Box = new System.Windows.Forms.TextBox();
            this.checksumMD5 = new System.Windows.Forms.CheckBox();
            this.checksumMD5Box = new System.Windows.Forms.TextBox();
            this.checksumComputeBtn = new System.Windows.Forms.Button();
            this.checksumComputeProgress = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fileBox.SuspendLayout();
            this.checksumBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileChooseBtn
            // 
            this.fileChooseBtn.Location = new System.Drawing.Point(6, 19);
            this.fileChooseBtn.Name = "fileChooseBtn";
            this.fileChooseBtn.Size = new System.Drawing.Size(99, 23);
            this.fileChooseBtn.TabIndex = 0;
            this.fileChooseBtn.Text = "Choose file...";
            this.fileChooseBtn.UseVisualStyleBackColor = true;
            this.fileChooseBtn.Click += new System.EventHandler(this.fileChooseBtn_Click);
            // 
            // fileBox
            // 
            this.fileBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileBox.Controls.Add(this.checksumCompareBox);
            this.fileBox.Controls.Add(this.label2);
            this.fileBox.Controls.Add(this.fileNameBox);
            this.fileBox.Controls.Add(this.label4);
            this.fileBox.Controls.Add(this.filePathBox);
            this.fileBox.Controls.Add(this.label3);
            this.fileBox.Controls.Add(this.fileSizeLabel);
            this.fileBox.Controls.Add(this.label1);
            this.fileBox.Controls.Add(this.fileChooseBtn);
            this.fileBox.Location = new System.Drawing.Point(13, 32);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(461, 172);
            this.fileBox.TabIndex = 1;
            this.fileBox.TabStop = false;
            this.fileBox.Text = "File properties";
            // 
            // checksumCompareBox
            // 
            this.checksumCompareBox.Location = new System.Drawing.Point(6, 139);
            this.checksumCompareBox.Name = "checksumCompareBox";
            this.checksumCompareBox.Size = new System.Drawing.Size(449, 20);
            this.checksumCompareBox.TabIndex = 5;
            this.checksumCompareBox.TextChanged += new System.EventHandler(this.checksumCompareBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Checksum to compare";
            // 
            // fileNameBox
            // 
            this.fileNameBox.Location = new System.Drawing.Point(6, 61);
            this.fileNameBox.Name = "fileNameBox";
            this.fileNameBox.ReadOnly = true;
            this.fileNameBox.Size = new System.Drawing.Size(449, 20);
            this.fileNameBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Absolute Path";
            // 
            // filePathBox
            // 
            this.filePathBox.Location = new System.Drawing.Point(6, 100);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.ReadOnly = true;
            this.filePathBox.Size = new System.Drawing.Size(449, 20);
            this.filePathBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "File name";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(144, 24);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(75, 13);
            this.fileSizeLabel.TabIndex = 3;
            this.fileSizeLabel.Text = "No file chosen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size:";
            // 
            // checksumBox
            // 
            this.checksumBox.AutoSize = true;
            this.checksumBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checksumBox.Controls.Add(this.checksumSHA512Box);
            this.checksumBox.Controls.Add(this.checksumSHA512);
            this.checksumBox.Controls.Add(this.checksumSHA256Box);
            this.checksumBox.Controls.Add(this.checksumSHA256);
            this.checksumBox.Controls.Add(this.checksumSHA1);
            this.checksumBox.Controls.Add(this.checksumSHA1Box);
            this.checksumBox.Controls.Add(this.checksumMD5);
            this.checksumBox.Controls.Add(this.checksumMD5Box);
            this.checksumBox.Controls.Add(this.checksumComputeBtn);
            this.checksumBox.Controls.Add(this.checksumComputeProgress);
            this.checksumBox.Enabled = false;
            this.checksumBox.Location = new System.Drawing.Point(12, 210);
            this.checksumBox.Name = "checksumBox";
            this.checksumBox.Size = new System.Drawing.Size(461, 165);
            this.checksumBox.TabIndex = 2;
            this.checksumBox.TabStop = false;
            this.checksumBox.Text = "Checksums";
            // 
            // checksumSHA512Box
            // 
            this.checksumSHA512Box.Location = new System.Drawing.Point(97, 126);
            this.checksumSHA512Box.Name = "checksumSHA512Box";
            this.checksumSHA512Box.ReadOnly = true;
            this.checksumSHA512Box.Size = new System.Drawing.Size(358, 20);
            this.checksumSHA512Box.TabIndex = 9;
            // 
            // checksumSHA512
            // 
            this.checksumSHA512.AutoSize = true;
            this.checksumSHA512.Location = new System.Drawing.Point(9, 128);
            this.checksumSHA512.Name = "checksumSHA512";
            this.checksumSHA512.Size = new System.Drawing.Size(66, 17);
            this.checksumSHA512.TabIndex = 8;
            this.checksumSHA512.Text = "SHA512";
            this.checksumSHA512.UseVisualStyleBackColor = true;
            this.checksumSHA512.CheckedChanged += new System.EventHandler(this.checksumAlgoChoose);
            // 
            // checksumSHA256Box
            // 
            this.checksumSHA256Box.Location = new System.Drawing.Point(97, 100);
            this.checksumSHA256Box.Name = "checksumSHA256Box";
            this.checksumSHA256Box.ReadOnly = true;
            this.checksumSHA256Box.Size = new System.Drawing.Size(358, 20);
            this.checksumSHA256Box.TabIndex = 7;
            // 
            // checksumSHA256
            // 
            this.checksumSHA256.AutoSize = true;
            this.checksumSHA256.Location = new System.Drawing.Point(9, 102);
            this.checksumSHA256.Name = "checksumSHA256";
            this.checksumSHA256.Size = new System.Drawing.Size(66, 17);
            this.checksumSHA256.TabIndex = 6;
            this.checksumSHA256.Text = "SHA256";
            this.checksumSHA256.UseVisualStyleBackColor = true;
            this.checksumSHA256.CheckedChanged += new System.EventHandler(this.checksumAlgoChoose);
            // 
            // checksumSHA1
            // 
            this.checksumSHA1.AutoSize = true;
            this.checksumSHA1.Location = new System.Drawing.Point(9, 76);
            this.checksumSHA1.Name = "checksumSHA1";
            this.checksumSHA1.Size = new System.Drawing.Size(54, 17);
            this.checksumSHA1.TabIndex = 5;
            this.checksumSHA1.Text = "SHA1";
            this.checksumSHA1.UseVisualStyleBackColor = true;
            this.checksumSHA1.CheckedChanged += new System.EventHandler(this.checksumAlgoChoose);
            // 
            // checksumSHA1Box
            // 
            this.checksumSHA1Box.Location = new System.Drawing.Point(97, 74);
            this.checksumSHA1Box.Name = "checksumSHA1Box";
            this.checksumSHA1Box.ReadOnly = true;
            this.checksumSHA1Box.Size = new System.Drawing.Size(358, 20);
            this.checksumSHA1Box.TabIndex = 4;
            // 
            // checksumMD5
            // 
            this.checksumMD5.AutoSize = true;
            this.checksumMD5.Location = new System.Drawing.Point(9, 50);
            this.checksumMD5.Name = "checksumMD5";
            this.checksumMD5.Size = new System.Drawing.Size(49, 17);
            this.checksumMD5.TabIndex = 3;
            this.checksumMD5.Text = "MD5";
            this.checksumMD5.UseVisualStyleBackColor = true;
            this.checksumMD5.CheckedChanged += new System.EventHandler(this.checksumAlgoChoose);
            // 
            // checksumMD5Box
            // 
            this.checksumMD5Box.Location = new System.Drawing.Point(97, 48);
            this.checksumMD5Box.Name = "checksumMD5Box";
            this.checksumMD5Box.ReadOnly = true;
            this.checksumMD5Box.Size = new System.Drawing.Size(358, 20);
            this.checksumMD5Box.TabIndex = 2;
            // 
            // checksumComputeBtn
            // 
            this.checksumComputeBtn.Enabled = false;
            this.checksumComputeBtn.Location = new System.Drawing.Point(9, 19);
            this.checksumComputeBtn.Name = "checksumComputeBtn";
            this.checksumComputeBtn.Size = new System.Drawing.Size(132, 23);
            this.checksumComputeBtn.TabIndex = 1;
            this.checksumComputeBtn.Text = "Calculate";
            this.checksumComputeBtn.UseVisualStyleBackColor = true;
            this.checksumComputeBtn.Click += new System.EventHandler(this.checksumComputeBtn_Click);
            // 
            // checksumComputeProgress
            // 
            this.checksumComputeProgress.Location = new System.Drawing.Point(147, 19);
            this.checksumComputeProgress.Name = "checksumComputeProgress";
            this.checksumComputeProgress.Size = new System.Drawing.Size(308, 23);
            this.checksumComputeProgress.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(486, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(101, 20);
            this.MenuAbout.Text = "About Program";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // Calculator
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(486, 387);
            this.Controls.Add(this.checksumBox);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculator";
            this.Text = "Checksum calculator";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.fileBox_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.fileBox_DragEnter);
            this.fileBox.ResumeLayout(false);
            this.fileBox.PerformLayout();
            this.checksumBox.ResumeLayout(false);
            this.checksumBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileChooseBtn;
        private System.Windows.Forms.GroupBox fileBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filePathBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.GroupBox checksumBox;
        private System.Windows.Forms.CheckBox checksumSHA1;
        private System.Windows.Forms.TextBox checksumSHA1Box;
        private System.Windows.Forms.CheckBox checksumMD5;
        private System.Windows.Forms.TextBox checksumMD5Box;
        private System.Windows.Forms.Button checksumComputeBtn;
        private System.Windows.Forms.ProgressBar checksumComputeProgress;
        private System.Windows.Forms.TextBox checksumSHA256Box;
        private System.Windows.Forms.CheckBox checksumSHA256;
        private System.Windows.Forms.TextBox checksumCompareBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox checksumSHA512Box;
        private System.Windows.Forms.CheckBox checksumSHA512;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
    }
}

