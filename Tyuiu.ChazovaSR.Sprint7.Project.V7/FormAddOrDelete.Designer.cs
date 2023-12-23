
namespace Tyuiu.ChazovaSR.Sprint7.Project.V7
{
    partial class FormAddOrDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddOrDelete));
            this.groupBoxDelete_CSR = new System.Windows.Forms.GroupBox();
            this.buttonDelete_CSR = new System.Windows.Forms.Button();
            this.buttonDeletePeople_CSR = new System.Windows.Forms.Button();
            this.labelDeleteEntrance_CSR = new System.Windows.Forms.Label();
            this.labelDeleteFlat_CSR = new System.Windows.Forms.Label();
            this.textBoxDeleteFlat_CSR = new System.Windows.Forms.TextBox();
            this.textBoxDeleteEntrance_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxReg_CSR = new System.Windows.Forms.GroupBox();
            this.labelForRent_CSR = new System.Windows.Forms.Label();
            this.labelOwnorRent_CSR = new System.Windows.Forms.Label();
            this.textBoxOwnOrRent_CSR = new System.Windows.Forms.TextBox();
            this.textBoxForRent_CSR = new System.Windows.Forms.TextBox();
            this.labelOwnerOrRent_CSR = new System.Windows.Forms.Label();
            this.buttonSaveFile_CSR = new System.Windows.Forms.Button();
            this.labelAddFlat_CSR = new System.Windows.Forms.Label();
            this.labelAddEntrance_CSR = new System.Windows.Forms.Label();
            this.labelFIO_CSR = new System.Windows.Forms.Label();
            this.radioButtonRent_CSR = new System.Windows.Forms.RadioButton();
            this.radioButtonOwn_CSR = new System.Windows.Forms.RadioButton();
            this.textBoxAddEntrance_CSR = new System.Windows.Forms.TextBox();
            this.textBoxAddFlat_CSR = new System.Windows.Forms.TextBox();
            this.textBoxFIO_CSR = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_CSR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInfo_CSR = new System.Windows.Forms.DataGridView();
            this.saveFileDialogInfoFlat_CSR = new System.Windows.Forms.SaveFileDialog();
            this.toolTipInfo_CSR = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxDelete_CSR.SuspendLayout();
            this.groupBoxReg_CSR.SuspendLayout();
            this.groupBoxInfo_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDelete_CSR
            // 
            this.groupBoxDelete_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDelete_CSR.Controls.Add(this.buttonDelete_CSR);
            this.groupBoxDelete_CSR.Controls.Add(this.buttonDeletePeople_CSR);
            this.groupBoxDelete_CSR.Controls.Add(this.labelDeleteEntrance_CSR);
            this.groupBoxDelete_CSR.Controls.Add(this.labelDeleteFlat_CSR);
            this.groupBoxDelete_CSR.Controls.Add(this.textBoxDeleteFlat_CSR);
            this.groupBoxDelete_CSR.Controls.Add(this.textBoxDeleteEntrance_CSR);
            this.groupBoxDelete_CSR.Location = new System.Drawing.Point(409, 302);
            this.groupBoxDelete_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDelete_CSR.Name = "groupBoxDelete_CSR";
            this.groupBoxDelete_CSR.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDelete_CSR.Size = new System.Drawing.Size(371, 182);
            this.groupBoxDelete_CSR.TabIndex = 10;
            this.groupBoxDelete_CSR.TabStop = false;
            this.groupBoxDelete_CSR.Text = "Выселение жильцов:";
            // 
            // buttonDelete_CSR
            // 
            this.buttonDelete_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete_CSR.Image")));
            this.buttonDelete_CSR.Location = new System.Drawing.Point(4, 116);
            this.buttonDelete_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete_CSR.Name = "buttonDelete_CSR";
            this.buttonDelete_CSR.Size = new System.Drawing.Size(91, 59);
            this.buttonDelete_CSR.TabIndex = 12;
            this.toolTipInfo_CSR.SetToolTip(this.buttonDelete_CSR, "Нажмите чтобы удалить жильца из базы данных");
            this.buttonDelete_CSR.UseVisualStyleBackColor = true;
            this.buttonDelete_CSR.Click += new System.EventHandler(this.buttonDelete_CSR_Click);
            // 
            // buttonDeletePeople_CSR
            // 
            this.buttonDeletePeople_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePeople_CSR.Image")));
            this.buttonDeletePeople_CSR.Location = new System.Drawing.Point(436, 11);
            this.buttonDeletePeople_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeletePeople_CSR.Name = "buttonDeletePeople_CSR";
            this.buttonDeletePeople_CSR.Size = new System.Drawing.Size(91, 59);
            this.buttonDeletePeople_CSR.TabIndex = 11;
            this.buttonDeletePeople_CSR.UseVisualStyleBackColor = true;
            // 
            // labelDeleteEntrance_CSR
            // 
            this.labelDeleteEntrance_CSR.AutoSize = true;
            this.labelDeleteEntrance_CSR.Location = new System.Drawing.Point(242, 15);
            this.labelDeleteEntrance_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeleteEntrance_CSR.Name = "labelDeleteEntrance_CSR";
            this.labelDeleteEntrance_CSR.Size = new System.Drawing.Size(96, 13);
            this.labelDeleteEntrance_CSR.TabIndex = 10;
            this.labelDeleteEntrance_CSR.Text = "Номер подъезда:";
            // 
            // labelDeleteFlat_CSR
            // 
            this.labelDeleteFlat_CSR.AutoSize = true;
            this.labelDeleteFlat_CSR.Location = new System.Drawing.Point(4, 15);
            this.labelDeleteFlat_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDeleteFlat_CSR.Name = "labelDeleteFlat_CSR";
            this.labelDeleteFlat_CSR.Size = new System.Drawing.Size(209, 13);
            this.labelDeleteFlat_CSR.TabIndex = 9;
            this.labelDeleteFlat_CSR.Text = "Номер квартиры из которой выселяют:";
            // 
            // textBoxDeleteFlat_CSR
            // 
            this.textBoxDeleteFlat_CSR.Location = new System.Drawing.Point(4, 32);
            this.textBoxDeleteFlat_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDeleteFlat_CSR.Name = "textBoxDeleteFlat_CSR";
            this.textBoxDeleteFlat_CSR.Size = new System.Drawing.Size(202, 20);
            this.textBoxDeleteFlat_CSR.TabIndex = 2;
            // 
            // textBoxDeleteEntrance_CSR
            // 
            this.textBoxDeleteEntrance_CSR.Location = new System.Drawing.Point(242, 31);
            this.textBoxDeleteEntrance_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDeleteEntrance_CSR.Name = "textBoxDeleteEntrance_CSR";
            this.textBoxDeleteEntrance_CSR.Size = new System.Drawing.Size(92, 20);
            this.textBoxDeleteEntrance_CSR.TabIndex = 1;
            // 
            // groupBoxReg_CSR
            // 
            this.groupBoxReg_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxReg_CSR.Controls.Add(this.labelForRent_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.labelOwnorRent_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.textBoxOwnOrRent_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.textBoxForRent_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.labelOwnerOrRent_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.buttonSaveFile_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.labelAddFlat_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.labelAddEntrance_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.labelFIO_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.radioButtonRent_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.radioButtonOwn_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.textBoxAddEntrance_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.textBoxAddFlat_CSR);
            this.groupBoxReg_CSR.Controls.Add(this.textBoxFIO_CSR);
            this.groupBoxReg_CSR.Location = new System.Drawing.Point(409, 10);
            this.groupBoxReg_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxReg_CSR.Name = "groupBoxReg_CSR";
            this.groupBoxReg_CSR.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxReg_CSR.Size = new System.Drawing.Size(371, 288);
            this.groupBoxReg_CSR.TabIndex = 9;
            this.groupBoxReg_CSR.TabStop = false;
            this.groupBoxReg_CSR.Text = "Регистрация новых жильцов:";
            // 
            // labelForRent_CSR
            // 
            this.labelForRent_CSR.AutoSize = true;
            this.labelForRent_CSR.Location = new System.Drawing.Point(5, 186);
            this.labelForRent_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelForRent_CSR.Name = "labelForRent_CSR";
            this.labelForRent_CSR.Size = new System.Drawing.Size(162, 13);
            this.labelForRent_CSR.TabIndex = 18;
            this.labelForRent_CSR.Text = "Примечание для арендателей:";
            // 
            // labelOwnorRent_CSR
            // 
            this.labelOwnorRent_CSR.AutoSize = true;
            this.labelOwnorRent_CSR.Location = new System.Drawing.Point(4, 125);
            this.labelOwnorRent_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOwnorRent_CSR.Name = "labelOwnorRent_CSR";
            this.labelOwnorRent_CSR.Size = new System.Drawing.Size(229, 26);
            this.labelOwnorRent_CSR.TabIndex = 17;
            this.labelOwnorRent_CSR.Text = "ФИО Арендатора\r\n(сначала выбрать собственник/арендатор):";
            // 
            // textBoxOwnOrRent_CSR
            // 
            this.textBoxOwnOrRent_CSR.Enabled = false;
            this.textBoxOwnOrRent_CSR.Location = new System.Drawing.Point(7, 155);
            this.textBoxOwnOrRent_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOwnOrRent_CSR.Name = "textBoxOwnOrRent_CSR";
            this.textBoxOwnOrRent_CSR.Size = new System.Drawing.Size(222, 20);
            this.textBoxOwnOrRent_CSR.TabIndex = 16;
            // 
            // textBoxForRent_CSR
            // 
            this.textBoxForRent_CSR.Location = new System.Drawing.Point(5, 201);
            this.textBoxForRent_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxForRent_CSR.Name = "textBoxForRent_CSR";
            this.textBoxForRent_CSR.Size = new System.Drawing.Size(222, 20);
            this.textBoxForRent_CSR.TabIndex = 15;
            // 
            // labelOwnerOrRent_CSR
            // 
            this.labelOwnerOrRent_CSR.AutoSize = true;
            this.labelOwnerOrRent_CSR.Location = new System.Drawing.Point(232, 125);
            this.labelOwnerOrRent_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOwnerOrRent_CSR.Name = "labelOwnerOrRent_CSR";
            this.labelOwnerOrRent_CSR.Size = new System.Drawing.Size(134, 13);
            this.labelOwnerOrRent_CSR.TabIndex = 14;
            this.labelOwnerOrRent_CSR.Text = "Собственник/арендатор:";
            // 
            // buttonSaveFile_CSR
            // 
            this.buttonSaveFile_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_CSR.Image")));
            this.buttonSaveFile_CSR.Location = new System.Drawing.Point(4, 223);
            this.buttonSaveFile_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveFile_CSR.Name = "buttonSaveFile_CSR";
            this.buttonSaveFile_CSR.Size = new System.Drawing.Size(91, 59);
            this.buttonSaveFile_CSR.TabIndex = 2;
            this.toolTipInfo_CSR.SetToolTip(this.buttonSaveFile_CSR, "Нажмите чтобы добавить жильца в базу данных");
            this.buttonSaveFile_CSR.UseVisualStyleBackColor = true;
            this.buttonSaveFile_CSR.Click += new System.EventHandler(this.buttonSaveFile_CSR_Click);
            // 
            // labelAddFlat_CSR
            // 
            this.labelAddFlat_CSR.AutoSize = true;
            this.labelAddFlat_CSR.Location = new System.Drawing.Point(4, 87);
            this.labelAddFlat_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddFlat_CSR.Name = "labelAddFlat_CSR";
            this.labelAddFlat_CSR.Size = new System.Drawing.Size(96, 13);
            this.labelAddFlat_CSR.TabIndex = 10;
            this.labelAddFlat_CSR.Text = "Номер квартиры:";
            // 
            // labelAddEntrance_CSR
            // 
            this.labelAddEntrance_CSR.AutoSize = true;
            this.labelAddEntrance_CSR.Location = new System.Drawing.Point(4, 52);
            this.labelAddEntrance_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddEntrance_CSR.Name = "labelAddEntrance_CSR";
            this.labelAddEntrance_CSR.Size = new System.Drawing.Size(96, 13);
            this.labelAddEntrance_CSR.TabIndex = 9;
            this.labelAddEntrance_CSR.Text = "Номер подъезда:";
            // 
            // labelFIO_CSR
            // 
            this.labelFIO_CSR.AutoSize = true;
            this.labelFIO_CSR.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelFIO_CSR.Location = new System.Drawing.Point(4, 17);
            this.labelFIO_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFIO_CSR.Name = "labelFIO_CSR";
            this.labelFIO_CSR.Size = new System.Drawing.Size(122, 13);
            this.labelFIO_CSR.TabIndex = 8;
            this.labelFIO_CSR.Text = "ФИО заселяющегося:";
            // 
            // radioButtonRent_CSR
            // 
            this.radioButtonRent_CSR.AutoSize = true;
            this.radioButtonRent_CSR.Location = new System.Drawing.Point(235, 162);
            this.radioButtonRent_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonRent_CSR.Name = "radioButtonRent_CSR";
            this.radioButtonRent_CSR.Size = new System.Drawing.Size(79, 17);
            this.radioButtonRent_CSR.TabIndex = 7;
            this.radioButtonRent_CSR.TabStop = true;
            this.radioButtonRent_CSR.Text = "Арендатор";
            this.radioButtonRent_CSR.UseVisualStyleBackColor = true;
            this.radioButtonRent_CSR.CheckedChanged += new System.EventHandler(this.radioButtonRent_CSR_CheckedChanged);
            // 
            // radioButtonOwn_CSR
            // 
            this.radioButtonOwn_CSR.AutoSize = true;
            this.radioButtonOwn_CSR.Location = new System.Drawing.Point(235, 140);
            this.radioButtonOwn_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOwn_CSR.Name = "radioButtonOwn_CSR";
            this.radioButtonOwn_CSR.Size = new System.Drawing.Size(91, 17);
            this.radioButtonOwn_CSR.TabIndex = 6;
            this.radioButtonOwn_CSR.TabStop = true;
            this.radioButtonOwn_CSR.Text = "Собственник";
            this.radioButtonOwn_CSR.UseVisualStyleBackColor = true;
            this.radioButtonOwn_CSR.CheckedChanged += new System.EventHandler(this.radioButtonOwn_CSR_CheckedChanged);
            // 
            // textBoxAddEntrance_CSR
            // 
            this.textBoxAddEntrance_CSR.Location = new System.Drawing.Point(4, 67);
            this.textBoxAddEntrance_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddEntrance_CSR.Name = "textBoxAddEntrance_CSR";
            this.textBoxAddEntrance_CSR.Size = new System.Drawing.Size(224, 20);
            this.textBoxAddEntrance_CSR.TabIndex = 2;
            // 
            // textBoxAddFlat_CSR
            // 
            this.textBoxAddFlat_CSR.Location = new System.Drawing.Point(4, 102);
            this.textBoxAddFlat_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAddFlat_CSR.Name = "textBoxAddFlat_CSR";
            this.textBoxAddFlat_CSR.Size = new System.Drawing.Size(224, 20);
            this.textBoxAddFlat_CSR.TabIndex = 1;
            // 
            // textBoxFIO_CSR
            // 
            this.textBoxFIO_CSR.Location = new System.Drawing.Point(4, 32);
            this.textBoxFIO_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFIO_CSR.Name = "textBoxFIO_CSR";
            this.textBoxFIO_CSR.Size = new System.Drawing.Size(224, 20);
            this.textBoxFIO_CSR.TabIndex = 0;
            // 
            // groupBoxInfo_CSR
            // 
            this.groupBoxInfo_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfo_CSR.Controls.Add(this.dataGridViewInfo_CSR);
            this.groupBoxInfo_CSR.Location = new System.Drawing.Point(6, 10);
            this.groupBoxInfo_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInfo_CSR.Name = "groupBoxInfo_CSR";
            this.groupBoxInfo_CSR.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInfo_CSR.Size = new System.Drawing.Size(394, 474);
            this.groupBoxInfo_CSR.TabIndex = 8;
            this.groupBoxInfo_CSR.TabStop = false;
            this.groupBoxInfo_CSR.Text = "Информация о жильцах";
            // 
            // dataGridViewInfo_CSR
            // 
            this.dataGridViewInfo_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfo_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo_CSR.ColumnHeadersVisible = false;
            this.dataGridViewInfo_CSR.Location = new System.Drawing.Point(2, 15);
            this.dataGridViewInfo_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInfo_CSR.Name = "dataGridViewInfo_CSR";
            this.dataGridViewInfo_CSR.RowHeadersVisible = false;
            this.dataGridViewInfo_CSR.RowHeadersWidth = 51;
            this.dataGridViewInfo_CSR.RowTemplate.Height = 24;
            this.dataGridViewInfo_CSR.Size = new System.Drawing.Size(388, 453);
            this.dataGridViewInfo_CSR.TabIndex = 0;
            // 
            // toolTipInfo_CSR
            // 
            this.toolTipInfo_CSR.Tag = "Подсказка";
            this.toolTipInfo_CSR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FormAddOrDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 494);
            this.Controls.Add(this.groupBoxDelete_CSR);
            this.Controls.Add(this.groupBoxReg_CSR);
            this.Controls.Add(this.groupBoxInfo_CSR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddOrDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заселение/выселение";
            this.groupBoxDelete_CSR.ResumeLayout(false);
            this.groupBoxDelete_CSR.PerformLayout();
            this.groupBoxReg_CSR.ResumeLayout(false);
            this.groupBoxReg_CSR.PerformLayout();
            this.groupBoxInfo_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo_CSR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDelete_CSR;
        private System.Windows.Forms.Button buttonDelete_CSR;
        private System.Windows.Forms.Button buttonDeletePeople_CSR;
        private System.Windows.Forms.Label labelDeleteEntrance_CSR;
        private System.Windows.Forms.Label labelDeleteFlat_CSR;
        private System.Windows.Forms.TextBox textBoxDeleteFlat_CSR;
        private System.Windows.Forms.TextBox textBoxDeleteEntrance_CSR;
        private System.Windows.Forms.GroupBox groupBoxReg_CSR;
        private System.Windows.Forms.Label labelForRent_CSR;
        private System.Windows.Forms.Label labelOwnorRent_CSR;
        private System.Windows.Forms.TextBox textBoxOwnOrRent_CSR;
        private System.Windows.Forms.TextBox textBoxForRent_CSR;
        private System.Windows.Forms.Label labelOwnerOrRent_CSR;
        private System.Windows.Forms.Button buttonSaveFile_CSR;
        private System.Windows.Forms.Label labelAddFlat_CSR;
        private System.Windows.Forms.Label labelAddEntrance_CSR;
        private System.Windows.Forms.Label labelFIO_CSR;
        private System.Windows.Forms.RadioButton radioButtonRent_CSR;
        private System.Windows.Forms.RadioButton radioButtonOwn_CSR;
        private System.Windows.Forms.TextBox textBoxAddEntrance_CSR;
        private System.Windows.Forms.TextBox textBoxAddFlat_CSR;
        private System.Windows.Forms.TextBox textBoxFIO_CSR;
        private System.Windows.Forms.GroupBox groupBoxInfo_CSR;
        private System.Windows.Forms.DataGridView dataGridViewInfo_CSR;
        private System.Windows.Forms.SaveFileDialog saveFileDialogInfoFlat_CSR;
        private System.Windows.Forms.ToolTip toolTipInfo_CSR;
    }
}