﻿
namespace Tyuiu.ChazovaSR.Sprint7.Project.V7
{
    partial class FormAboutMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAboutMe));
            this.pictureBoxAvatar_CSR = new System.Windows.Forms.PictureBox();
            this.buttonOK_CSR = new System.Windows.Forms.Button();
            this.labelInfo_CSR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_CSR
            // 
            this.pictureBoxAvatar_CSR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_CSR.Image")));
            this.pictureBoxAvatar_CSR.Location = new System.Drawing.Point(5, 10);
            this.pictureBoxAvatar_CSR.Name = "pictureBoxAvatar_CSR";
            this.pictureBoxAvatar_CSR.Size = new System.Drawing.Size(146, 185);
            this.pictureBoxAvatar_CSR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_CSR.TabIndex = 10;
            this.pictureBoxAvatar_CSR.TabStop = false;
            // 
            // buttonOK_CSR
            // 
            this.buttonOK_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOK_CSR.Location = new System.Drawing.Point(366, 172);
            this.buttonOK_CSR.Name = "buttonOK_CSR";
            this.buttonOK_CSR.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_CSR.TabIndex = 9;
            this.buttonOK_CSR.Text = "ОК";
            this.buttonOK_CSR.UseVisualStyleBackColor = true;
            this.buttonOK_CSR.Click += new System.EventHandler(this.buttonOK_CSR_Click);
            // 
            // labelInfo_CSR
            // 
            this.labelInfo_CSR.AutoSize = true;
            this.labelInfo_CSR.Location = new System.Drawing.Point(157, 24);
            this.labelInfo_CSR.Name = "labelInfo_CSR";
            this.labelInfo_CSR.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_CSR.TabIndex = 8;
            this.labelInfo_CSR.Text = resources.GetString("labelInfo_CSR.Text");
            // 
            // FormAboutMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 219);
            this.Controls.Add(this.pictureBoxAvatar_CSR);
            this.Controls.Add(this.buttonOK_CSR);
            this.Controls.Add(this.labelInfo_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAboutMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_CSR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_CSR;
        private System.Windows.Forms.Button buttonOK_CSR;
        private System.Windows.Forms.Label labelInfo_CSR;
    }
}