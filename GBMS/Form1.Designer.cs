﻿namespace GBMS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ObjectToScanComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateListButton = new System.Windows.Forms.Button();
            this.DeviceTypeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 278);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ObjectToScanComboBox
            // 
            this.ObjectToScanComboBox.FormattingEnabled = true;
            this.ObjectToScanComboBox.Location = new System.Drawing.Point(491, 54);
            this.ObjectToScanComboBox.Name = "ObjectToScanComboBox";
            this.ObjectToScanComboBox.Size = new System.Drawing.Size(121, 20);
            this.ObjectToScanComboBox.TabIndex = 3;
            // 
            // UpdateListButton
            // 
            this.UpdateListButton.Location = new System.Drawing.Point(283, 301);
            this.UpdateListButton.Name = "UpdateListButton";
            this.UpdateListButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateListButton.TabIndex = 4;
            this.UpdateListButton.Text = "获取设备";
            this.UpdateListButton.UseVisualStyleBackColor = true;
            this.UpdateListButton.Click += new System.EventHandler(this.UpdateListButton_Click);
            // 
            // DeviceTypeComboBox
            // 
            this.DeviceTypeComboBox.FormattingEnabled = true;
            this.DeviceTypeComboBox.Location = new System.Drawing.Point(491, 107);
            this.DeviceTypeComboBox.Name = "DeviceTypeComboBox";
            this.DeviceTypeComboBox.Size = new System.Drawing.Size(121, 20);
            this.DeviceTypeComboBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 356);
            this.Controls.Add(this.DeviceTypeComboBox);
            this.Controls.Add(this.UpdateListButton);
            this.Controls.Add(this.ObjectToScanComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox ObjectToScanComboBox;
        private System.Windows.Forms.Button UpdateListButton;
        private System.Windows.Forms.ComboBox DeviceTypeComboBox;
    }
}

