
namespace Tyuiu.ChazovaSR.Sprint7.Project.V7
{
    partial class FormDebt
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebt));
            this.groupBoxSearch_CSR = new System.Windows.Forms.GroupBox();
            this.labelFIO_CSR = new System.Windows.Forms.Label();
            this.textBoxFIO_CSR = new System.Windows.Forms.TextBox();
            this.buttonSearch_CSR = new System.Windows.Forms.Button();
            this.buttonBack_CSR = new System.Windows.Forms.Button();
            this.buttonGetDataTable_CSR = new System.Windows.Forms.Button();
            this.groupBoxInfoPeople_CSR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInfoPeople_CSR = new System.Windows.Forms.DataGridView();
            this.openFileDialogGetDataTable_CSR = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo_CSR = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSearch_CSR.SuspendLayout();
            this.groupBoxInfoPeople_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPeople_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSearch_CSR
            // 
            this.groupBoxSearch_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxSearch_CSR.Controls.Add(this.labelFIO_CSR);
            this.groupBoxSearch_CSR.Controls.Add(this.textBoxFIO_CSR);
            this.groupBoxSearch_CSR.Controls.Add(this.buttonSearch_CSR);
            this.groupBoxSearch_CSR.Location = new System.Drawing.Point(12, 416);
            this.groupBoxSearch_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSearch_CSR.Name = "groupBoxSearch_CSR";
            this.groupBoxSearch_CSR.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSearch_CSR.Size = new System.Drawing.Size(261, 70);
            this.groupBoxSearch_CSR.TabIndex = 24;
            this.groupBoxSearch_CSR.TabStop = false;
            this.groupBoxSearch_CSR.Text = "Поиск";
            // 
            // labelFIO_CSR
            // 
            this.labelFIO_CSR.AutoSize = true;
            this.labelFIO_CSR.Location = new System.Drawing.Point(14, 24);
            this.labelFIO_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFIO_CSR.Name = "labelFIO_CSR";
            this.labelFIO_CSR.Size = new System.Drawing.Size(79, 13);
            this.labelFIO_CSR.TabIndex = 17;
            this.labelFIO_CSR.Text = "Введите ФИО";
            // 
            // textBoxFIO_CSR
            // 
            this.textBoxFIO_CSR.Location = new System.Drawing.Point(9, 41);
            this.textBoxFIO_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFIO_CSR.Name = "textBoxFIO_CSR";
            this.textBoxFIO_CSR.Size = new System.Drawing.Size(138, 20);
            this.textBoxFIO_CSR.TabIndex = 16;
            // 
            // buttonSearch_CSR
            // 
            this.buttonSearch_CSR.Location = new System.Drawing.Point(151, 41);
            this.buttonSearch_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch_CSR.Name = "buttonSearch_CSR";
            this.buttonSearch_CSR.Size = new System.Drawing.Size(102, 19);
            this.buttonSearch_CSR.TabIndex = 18;
            this.buttonSearch_CSR.Text = "Найти";
            this.buttonSearch_CSR.UseVisualStyleBackColor = true;
            this.buttonSearch_CSR.Click += new System.EventHandler(this.buttonSearch_CSR_Click);
            // 
            // buttonBack_CSR
            // 
            this.buttonBack_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack_CSR.Enabled = false;
            this.buttonBack_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack_CSR.Image")));
            this.buttonBack_CSR.Location = new System.Drawing.Point(644, 48);
            this.buttonBack_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack_CSR.Name = "buttonBack_CSR";
            this.buttonBack_CSR.Size = new System.Drawing.Size(109, 45);
            this.buttonBack_CSR.TabIndex = 23;
            this.toolTipInfo_CSR.SetToolTip(this.buttonBack_CSR, "Вернуть изначальную базу данных");
            this.buttonBack_CSR.UseVisualStyleBackColor = true;
            this.buttonBack_CSR.Click += new System.EventHandler(this.buttonBack_CSR_Click);
            // 
            // buttonGetDataTable_CSR
            // 
            this.buttonGetDataTable_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetDataTable_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetDataTable_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonGetDataTable_CSR.Image")));
            this.buttonGetDataTable_CSR.Location = new System.Drawing.Point(7, 2);
            this.buttonGetDataTable_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetDataTable_CSR.Name = "buttonGetDataTable_CSR";
            this.buttonGetDataTable_CSR.Size = new System.Drawing.Size(746, 43);
            this.buttonGetDataTable_CSR.TabIndex = 22;
            this.buttonGetDataTable_CSR.Text = "\r\n";
            this.toolTipInfo_CSR.SetToolTip(this.buttonGetDataTable_CSR, "Нажмите, чтобы выгрузить базу данных");
            this.buttonGetDataTable_CSR.UseVisualStyleBackColor = true;
            this.buttonGetDataTable_CSR.Click += new System.EventHandler(this.buttonGetDataTable_CSR_Click_1);
            // 
            // groupBoxInfoPeople_CSR
            // 
            this.groupBoxInfoPeople_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfoPeople_CSR.Controls.Add(this.dataGridViewInfoPeople_CSR);
            this.groupBoxInfoPeople_CSR.Location = new System.Drawing.Point(7, 93);
            this.groupBoxInfoPeople_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInfoPeople_CSR.Name = "groupBoxInfoPeople_CSR";
            this.groupBoxInfoPeople_CSR.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInfoPeople_CSR.Size = new System.Drawing.Size(746, 322);
            this.groupBoxInfoPeople_CSR.TabIndex = 21;
            this.groupBoxInfoPeople_CSR.TabStop = false;
            this.groupBoxInfoPeople_CSR.Text = "Информация о задолженностях:";
            // 
            // dataGridViewInfoPeople_CSR
            // 
            this.dataGridViewInfoPeople_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfoPeople_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoPeople_CSR.ColumnHeadersVisible = false;
            this.dataGridViewInfoPeople_CSR.Location = new System.Drawing.Point(4, 16);
            this.dataGridViewInfoPeople_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInfoPeople_CSR.Name = "dataGridViewInfoPeople_CSR";
            this.dataGridViewInfoPeople_CSR.RowHeadersVisible = false;
            this.dataGridViewInfoPeople_CSR.RowHeadersWidth = 51;
            this.dataGridViewInfoPeople_CSR.RowTemplate.Height = 24;
            this.dataGridViewInfoPeople_CSR.Size = new System.Drawing.Size(737, 300);
            this.dataGridViewInfoPeople_CSR.TabIndex = 0;
            // 
            // openFileDialogGetDataTable_CSR
            // 
            this.openFileDialogGetDataTable_CSR.FileName = "openFileDialog1";
            // 
            // toolTipInfo_CSR
            // 
            this.toolTipInfo_CSR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo_CSR.ToolTipTitle = "Подсказка";
            // 
            // FormDebt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 495);
            this.Controls.Add(this.groupBoxSearch_CSR);
            this.Controls.Add(this.buttonBack_CSR);
            this.Controls.Add(this.buttonGetDataTable_CSR);
            this.Controls.Add(this.groupBoxInfoPeople_CSR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDebt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задолженности";
            this.groupBoxSearch_CSR.ResumeLayout(false);
            this.groupBoxSearch_CSR.PerformLayout();
            this.groupBoxInfoPeople_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPeople_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSearch_CSR;
        private System.Windows.Forms.Label labelFIO_CSR;
        private System.Windows.Forms.TextBox textBoxFIO_CSR;
        private System.Windows.Forms.Button buttonSearch_CSR;
        private System.Windows.Forms.Button buttonBack_CSR;
        private System.Windows.Forms.Button buttonGetDataTable_CSR;
        private System.Windows.Forms.GroupBox groupBoxInfoPeople_CSR;
        private System.Windows.Forms.DataGridView dataGridViewInfoPeople_CSR;
        private System.Windows.Forms.OpenFileDialog openFileDialogGetDataTable_CSR;
        private System.Windows.Forms.ToolTip toolTipInfo_CSR;
    }
}