
namespace Tyuiu.ChazovaSR.Sprint7.Project.V7
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.labelGuide_CSR = new System.Windows.Forms.Label();
            this.buttonOk_CSR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGuide_CSR
            // 
            this.labelGuide_CSR.AutoSize = true;
            this.labelGuide_CSR.Location = new System.Drawing.Point(-1, 9);
            this.labelGuide_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGuide_CSR.Name = "labelGuide_CSR";
            this.labelGuide_CSR.Size = new System.Drawing.Size(558, 182);
            this.labelGuide_CSR.TabIndex = 1;
            this.labelGuide_CSR.Text = resources.GetString("labelGuide_CSR.Text");
            // 
            // buttonOk_CSR
            // 
            this.buttonOk_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOk_CSR.Location = new System.Drawing.Point(482, 182);
            this.buttonOk_CSR.Name = "buttonOk_CSR";
            this.buttonOk_CSR.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_CSR.TabIndex = 2;
            this.buttonOk_CSR.Text = "ОК";
            this.buttonOk_CSR.UseVisualStyleBackColor = true;
            this.buttonOk_CSR.Click += new System.EventHandler(this.buttonOk_CSR_Click);
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 217);
            this.Controls.Add(this.buttonOk_CSR);
            this.Controls.Add(this.labelGuide_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGuide_CSR;
        private System.Windows.Forms.Button buttonOk_CSR;
    }
}