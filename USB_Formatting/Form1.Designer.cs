using System;

namespace USB_Formatting
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.FormatType = new System.Windows.Forms.Label();
            this.FreeSpace = new System.Windows.Forms.Label();
            this.TotalSpace = new System.Windows.Forms.Label();
            this.FormatTypeLabel = new System.Windows.Forms.Label();
            this.FreeSize = new System.Windows.Forms.Label();
            this.TotalSize = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Normal_rbtn = new System.Windows.Forms.RadioButton();
            this.Quick_rbtn = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FAT32 = new System.Windows.Forms.RadioButton();
            this.NTFS = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.USBPath = new System.Windows.Forms.ComboBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "تهيئة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.FormatButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "أختيار القرص:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(225, 262);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاعدادات";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FormatType);
            this.groupBox4.Controls.Add(this.FreeSpace);
            this.groupBox4.Controls.Add(this.TotalSpace);
            this.groupBox4.Controls.Add(this.FormatTypeLabel);
            this.groupBox4.Controls.Add(this.FreeSize);
            this.groupBox4.Controls.Add(this.TotalSize);
            this.groupBox4.Location = new System.Drawing.Point(6, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 120);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الاعدادات الحالية";
            // 
            // FormatType
            // 
            this.FormatType.AutoSize = true;
            this.FormatType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatType.Location = new System.Drawing.Point(38, 81);
            this.FormatType.Name = "FormatType";
            this.FormatType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FormatType.Size = new System.Drawing.Size(13, 13);
            this.FormatType.TabIndex = 5;
            this.FormatType.Text = "0";
            this.FormatType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreeSpace
            // 
            this.FreeSpace.AutoSize = true;
            this.FreeSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeSpace.Location = new System.Drawing.Point(38, 57);
            this.FreeSpace.Name = "FreeSpace";
            this.FreeSpace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FreeSpace.Size = new System.Drawing.Size(13, 13);
            this.FreeSpace.TabIndex = 4;
            this.FreeSpace.Text = "0";
            this.FreeSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSpace
            // 
            this.TotalSpace.AutoSize = true;
            this.TotalSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSpace.Location = new System.Drawing.Point(38, 33);
            this.TotalSpace.Name = "TotalSpace";
            this.TotalSpace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalSpace.Size = new System.Drawing.Size(13, 13);
            this.TotalSpace.TabIndex = 3;
            this.TotalSpace.Text = "0";
            this.TotalSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormatTypeLabel
            // 
            this.FormatTypeLabel.AutoSize = true;
            this.FormatTypeLabel.Location = new System.Drawing.Point(116, 81);
            this.FormatTypeLabel.Name = "FormatTypeLabel";
            this.FormatTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FormatTypeLabel.Size = new System.Drawing.Size(91, 13);
            this.FormatTypeLabel.TabIndex = 2;
            this.FormatTypeLabel.Text = "نوع التهيئة الحالية:";
            this.FormatTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreeSize
            // 
            this.FreeSize.AutoSize = true;
            this.FreeSize.Location = new System.Drawing.Point(125, 57);
            this.FreeSize.Name = "FreeSize";
            this.FreeSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FreeSize.Size = new System.Drawing.Size(82, 13);
            this.FreeSize.TabIndex = 1;
            this.FreeSize.Text = "المساحة المتبقية:";
            this.FreeSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalSize
            // 
            this.TotalSize.AutoSize = true;
            this.TotalSize.Location = new System.Drawing.Point(133, 33);
            this.TotalSize.Name = "TotalSize";
            this.TotalSize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TotalSize.Size = new System.Drawing.Size(74, 13);
            this.TotalSize.TabIndex = 0;
            this.TotalSize.Text = "المساحة الكلية:";
            this.TotalSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Normal_rbtn);
            this.groupBox3.Controls.Add(this.Quick_rbtn);
            this.groupBox3.Location = new System.Drawing.Point(6, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 45);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "سرعة التهيئة";
            // 
            // Normal_rbtn
            // 
            this.Normal_rbtn.AutoSize = true;
            this.Normal_rbtn.Location = new System.Drawing.Point(12, 19);
            this.Normal_rbtn.Name = "Normal_rbtn";
            this.Normal_rbtn.Size = new System.Drawing.Size(51, 17);
            this.Normal_rbtn.TabIndex = 2;
            this.Normal_rbtn.TabStop = true;
            this.Normal_rbtn.Text = "عادي";
            this.Normal_rbtn.UseVisualStyleBackColor = true;
            // 
            // Quick_rbtn
            // 
            this.Quick_rbtn.AutoSize = true;
            this.Quick_rbtn.Location = new System.Drawing.Point(92, 19);
            this.Quick_rbtn.Name = "Quick_rbtn";
            this.Quick_rbtn.Size = new System.Drawing.Size(50, 17);
            this.Quick_rbtn.TabIndex = 1;
            this.Quick_rbtn.TabStop = true;
            this.Quick_rbtn.Text = "سريع";
            this.Quick_rbtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FAT32);
            this.groupBox2.Controls.Add(this.NTFS);
            this.groupBox2.Location = new System.Drawing.Point(6, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 45);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع التهيئة";
            // 
            // FAT32
            // 
            this.FAT32.AutoSize = true;
            this.FAT32.Location = new System.Drawing.Point(6, 19);
            this.FAT32.Name = "FAT32";
            this.FAT32.Size = new System.Drawing.Size(57, 17);
            this.FAT32.TabIndex = 1;
            this.FAT32.TabStop = true;
            this.FAT32.Text = "FAT32";
            this.FAT32.UseVisualStyleBackColor = true;
            // 
            // NTFS
            // 
            this.NTFS.AutoSize = true;
            this.NTFS.Location = new System.Drawing.Point(89, 19);
            this.NTFS.Name = "NTFS";
            this.NTFS.Size = new System.Drawing.Size(53, 17);
            this.NTFS.TabIndex = 0;
            this.NTFS.TabStop = true;
            this.NTFS.Text = "NTFS";
            this.NTFS.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(117, 342);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.UseCompatibleTextRendering = true;
            // 
            // USBPath
            // 
            this.USBPath.FormattingEnabled = true;
            this.USBPath.Location = new System.Drawing.Point(42, 12);
            this.USBPath.Name = "USBPath";
            this.USBPath.Size = new System.Drawing.Size(122, 21);
            this.USBPath.TabIndex = 5;
            this.USBPath.SelectedIndexChanged += new System.EventHandler(this.USBPath_SelectedIndexChanged);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.Location = new System.Drawing.Point(11, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(25, 21);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Programming by: Sajjad Mohammed Baqer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(251, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.USBPath);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "USB تهيئة الـ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton FAT32;
        private System.Windows.Forms.RadioButton NTFS;
        private System.Windows.Forms.RadioButton Normal_rbtn;
        private System.Windows.Forms.RadioButton Quick_rbtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label TotalSize;
        private System.Windows.Forms.Label FreeSize;
        private System.Windows.Forms.Label FormatTypeLabel;
        private System.Windows.Forms.Label TotalSpace;
        private System.Windows.Forms.Label FreeSpace;
        private System.Windows.Forms.Label FormatType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox USBPath;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Label label2;
    }
}

