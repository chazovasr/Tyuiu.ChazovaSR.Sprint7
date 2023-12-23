
namespace Tyuiu.ChazovaSR.Sprint7.Project.V7
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonBack_CSR = new System.Windows.Forms.Button();
            this.buttonGetDataTable_CSR = new System.Windows.Forms.Button();
            this.buttonOwnOrRent_CSR = new System.Windows.Forms.Button();
            this.buttonFlatChart_CSR = new System.Windows.Forms.Button();
            this.groupBoxFilters_CSR = new System.Windows.Forms.GroupBox();
            this.labelRenter_CSR = new System.Windows.Forms.Label();
            this.buttonBeginOwn_CSR = new System.Windows.Forms.Button();
            this.buttonbBeginRent_CSR = new System.Windows.Forms.Button();
            this.labelEntrance_CSR = new System.Windows.Forms.Label();
            this.buttonMaxEntrance_CSR = new System.Windows.Forms.Button();
            this.buttonMinEntrance_CSR = new System.Windows.Forms.Button();
            this.groupBoxInfoPeople_CSR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInfoPeople_CSR = new System.Windows.Forms.DataGridView();
            this.toolTipInfo_CSR = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogGetDataTable_CSR = new System.Windows.Forms.OpenFileDialog();
            this.menuStripAll_CSR = new System.Windows.Forms.MenuStrip();
            this.MenuItemFirst_CSR = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDebt_CSR = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemChange_CSR = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInfo_CSR = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout_CSR = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGuide_CSR = new System.Windows.Forms.ToolStripMenuItem();
            this.chartInfo_CSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxFilters_CSR.SuspendLayout();
            this.groupBoxInfoPeople_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPeople_CSR)).BeginInit();
            this.menuStripAll_CSR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_CSR)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack_CSR
            // 
            this.buttonBack_CSR.Enabled = false;
            this.buttonBack_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack_CSR.Image")));
            this.buttonBack_CSR.Location = new System.Drawing.Point(221, 266);
            this.buttonBack_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack_CSR.Name = "buttonBack_CSR";
            this.buttonBack_CSR.Size = new System.Drawing.Size(51, 92);
            this.buttonBack_CSR.TabIndex = 22;
            this.toolTipInfo_CSR.SetToolTip(this.buttonBack_CSR, "Вернуть базу данных без фильтров");
            this.buttonBack_CSR.UseVisualStyleBackColor = true;
            this.buttonBack_CSR.Click += new System.EventHandler(this.buttonBack_CSR_Click);
            // 
            // buttonGetDataTable_CSR
            // 
            this.buttonGetDataTable_CSR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetDataTable_CSR.Image = ((System.Drawing.Image)(resources.GetObject("buttonGetDataTable_CSR.Image")));
            this.buttonGetDataTable_CSR.Location = new System.Drawing.Point(14, 266);
            this.buttonGetDataTable_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetDataTable_CSR.Name = "buttonGetDataTable_CSR";
            this.buttonGetDataTable_CSR.Size = new System.Drawing.Size(203, 92);
            this.buttonGetDataTable_CSR.TabIndex = 21;
            this.buttonGetDataTable_CSR.Text = "\r\n";
            this.toolTipInfo_CSR.SetToolTip(this.buttonGetDataTable_CSR, "Вывести базу данных дома ниже");
            this.buttonGetDataTable_CSR.UseVisualStyleBackColor = true;
            this.buttonGetDataTable_CSR.Click += new System.EventHandler(this.buttonGetDataTable_CSR_Click);
            // 
            // buttonOwnOrRent_CSR
            // 
            this.buttonOwnOrRent_CSR.Location = new System.Drawing.Point(14, 154);
            this.buttonOwnOrRent_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOwnOrRent_CSR.Name = "buttonOwnOrRent_CSR";
            this.buttonOwnOrRent_CSR.Size = new System.Drawing.Size(124, 80);
            this.buttonOwnOrRent_CSR.TabIndex = 20;
            this.buttonOwnOrRent_CSR.Text = "Вывести график количества собственников и арендаторов";
            this.buttonOwnOrRent_CSR.UseVisualStyleBackColor = true;
            this.buttonOwnOrRent_CSR.Click += new System.EventHandler(this.buttonOwnOrRent_CSR_Click);
            // 
            // buttonFlatChart_CSR
            // 
            this.buttonFlatChart_CSR.Location = new System.Drawing.Point(14, 69);
            this.buttonFlatChart_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFlatChart_CSR.Name = "buttonFlatChart_CSR";
            this.buttonFlatChart_CSR.Size = new System.Drawing.Size(124, 80);
            this.buttonFlatChart_CSR.TabIndex = 19;
            this.buttonFlatChart_CSR.Text = "Вывести график количества квартир в каждом подъезде";
            this.buttonFlatChart_CSR.UseVisualStyleBackColor = true;
            this.buttonFlatChart_CSR.Click += new System.EventHandler(this.buttonFlatChart_CSR_Click);
            // 
            // groupBoxFilters_CSR
            // 
            this.groupBoxFilters_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters_CSR.Controls.Add(this.labelRenter_CSR);
            this.groupBoxFilters_CSR.Controls.Add(this.buttonBeginOwn_CSR);
            this.groupBoxFilters_CSR.Controls.Add(this.buttonbBeginRent_CSR);
            this.groupBoxFilters_CSR.Controls.Add(this.labelEntrance_CSR);
            this.groupBoxFilters_CSR.Controls.Add(this.buttonMaxEntrance_CSR);
            this.groupBoxFilters_CSR.Controls.Add(this.buttonMinEntrance_CSR);
            this.groupBoxFilters_CSR.Location = new System.Drawing.Point(277, 266);
            this.groupBoxFilters_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFilters_CSR.Name = "groupBoxFilters_CSR";
            this.groupBoxFilters_CSR.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFilters_CSR.Size = new System.Drawing.Size(678, 92);
            this.groupBoxFilters_CSR.TabIndex = 18;
            this.groupBoxFilters_CSR.TabStop = false;
            this.groupBoxFilters_CSR.Text = "Фильтры";
            // 
            // labelRenter_CSR
            // 
            this.labelRenter_CSR.AutoSize = true;
            this.labelRenter_CSR.Location = new System.Drawing.Point(178, 15);
            this.labelRenter_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRenter_CSR.Name = "labelRenter_CSR";
            this.labelRenter_CSR.Size = new System.Drawing.Size(214, 13);
            this.labelRenter_CSR.TabIndex = 11;
            this.labelRenter_CSR.Text = "Сортировка по аренадатор/собственник";
            // 
            // buttonBeginOwn_CSR
            // 
            this.buttonBeginOwn_CSR.Enabled = false;
            this.buttonBeginOwn_CSR.Location = new System.Drawing.Point(181, 60);
            this.buttonBeginOwn_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBeginOwn_CSR.Name = "buttonBeginOwn_CSR";
            this.buttonBeginOwn_CSR.Size = new System.Drawing.Size(205, 24);
            this.buttonBeginOwn_CSR.TabIndex = 10;
            this.buttonBeginOwn_CSR.Text = "сначала собственники";
            this.buttonBeginOwn_CSR.UseVisualStyleBackColor = true;
            this.buttonBeginOwn_CSR.Click += new System.EventHandler(this.buttonBeginOwn_CSR_Click);
            // 
            // buttonbBeginRent_CSR
            // 
            this.buttonbBeginRent_CSR.Enabled = false;
            this.buttonbBeginRent_CSR.Location = new System.Drawing.Point(181, 31);
            this.buttonbBeginRent_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonbBeginRent_CSR.Name = "buttonbBeginRent_CSR";
            this.buttonbBeginRent_CSR.Size = new System.Drawing.Size(205, 24);
            this.buttonbBeginRent_CSR.TabIndex = 9;
            this.buttonbBeginRent_CSR.Text = "сначала арендаторы";
            this.buttonbBeginRent_CSR.UseVisualStyleBackColor = true;
            this.buttonbBeginRent_CSR.Click += new System.EventHandler(this.buttonbBeginRent_CSR_Click);
            // 
            // labelEntrance_CSR
            // 
            this.labelEntrance_CSR.AutoSize = true;
            this.labelEntrance_CSR.Location = new System.Drawing.Point(4, 15);
            this.labelEntrance_CSR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEntrance_CSR.Name = "labelEntrance_CSR";
            this.labelEntrance_CSR.Size = new System.Drawing.Size(174, 13);
            this.labelEntrance_CSR.TabIndex = 2;
            this.labelEntrance_CSR.Text = "Сортировка по номеру подъезда";
            // 
            // buttonMaxEntrance_CSR
            // 
            this.buttonMaxEntrance_CSR.Enabled = false;
            this.buttonMaxEntrance_CSR.Location = new System.Drawing.Point(7, 60);
            this.buttonMaxEntrance_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaxEntrance_CSR.Name = "buttonMaxEntrance_CSR";
            this.buttonMaxEntrance_CSR.Size = new System.Drawing.Size(167, 24);
            this.buttonMaxEntrance_CSR.TabIndex = 1;
            this.buttonMaxEntrance_CSR.Text = "max";
            this.buttonMaxEntrance_CSR.UseVisualStyleBackColor = true;
            this.buttonMaxEntrance_CSR.Click += new System.EventHandler(this.buttonMaxEntrance_CSR_Click);
            // 
            // buttonMinEntrance_CSR
            // 
            this.buttonMinEntrance_CSR.Enabled = false;
            this.buttonMinEntrance_CSR.Location = new System.Drawing.Point(7, 31);
            this.buttonMinEntrance_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinEntrance_CSR.Name = "buttonMinEntrance_CSR";
            this.buttonMinEntrance_CSR.Size = new System.Drawing.Size(167, 24);
            this.buttonMinEntrance_CSR.TabIndex = 0;
            this.buttonMinEntrance_CSR.Text = "min";
            this.buttonMinEntrance_CSR.UseVisualStyleBackColor = true;
            this.buttonMinEntrance_CSR.Click += new System.EventHandler(this.buttonMinEntrance_CSR_Click);
            // 
            // groupBoxInfoPeople_CSR
            // 
            this.groupBoxInfoPeople_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInfoPeople_CSR.Controls.Add(this.dataGridViewInfoPeople_CSR);
            this.groupBoxInfoPeople_CSR.Location = new System.Drawing.Point(9, 363);
            this.groupBoxInfoPeople_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInfoPeople_CSR.Name = "groupBoxInfoPeople_CSR";
            this.groupBoxInfoPeople_CSR.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInfoPeople_CSR.Size = new System.Drawing.Size(946, 161);
            this.groupBoxInfoPeople_CSR.TabIndex = 17;
            this.groupBoxInfoPeople_CSR.TabStop = false;
            this.groupBoxInfoPeople_CSR.Text = "Информация о жильцах:";
            // 
            // dataGridViewInfoPeople_CSR
            // 
            this.dataGridViewInfoPeople_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfoPeople_CSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfoPeople_CSR.ColumnHeadersVisible = false;
            this.dataGridViewInfoPeople_CSR.Location = new System.Drawing.Point(4, 17);
            this.dataGridViewInfoPeople_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInfoPeople_CSR.Name = "dataGridViewInfoPeople_CSR";
            this.dataGridViewInfoPeople_CSR.RowHeadersVisible = false;
            this.dataGridViewInfoPeople_CSR.RowHeadersWidth = 51;
            this.dataGridViewInfoPeople_CSR.RowTemplate.Height = 24;
            this.dataGridViewInfoPeople_CSR.Size = new System.Drawing.Size(937, 139);
            this.dataGridViewInfoPeople_CSR.TabIndex = 0;
            // 
            // toolTipInfo_CSR
            // 
            this.toolTipInfo_CSR.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialogGetDataTable_CSR
            // 
            this.openFileDialogGetDataTable_CSR.FileName = "openFileDialog1";
            // 
            // menuStripAll_CSR
            // 
            this.menuStripAll_CSR.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripAll_CSR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFirst_CSR,
            this.ToolStripMenuItemInfo_CSR});
            this.menuStripAll_CSR.Location = new System.Drawing.Point(0, 0);
            this.menuStripAll_CSR.Name = "menuStripAll_CSR";
            this.menuStripAll_CSR.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripAll_CSR.Size = new System.Drawing.Size(964, 24);
            this.menuStripAll_CSR.TabIndex = 23;
            this.menuStripAll_CSR.Text = "menuStrip1";
            // 
            // MenuItemFirst_CSR
            // 
            this.MenuItemFirst_CSR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDebt_CSR,
            this.ToolStripMenuItemChange_CSR});
            this.MenuItemFirst_CSR.Name = "MenuItemFirst_CSR";
            this.MenuItemFirst_CSR.Size = new System.Drawing.Size(99, 20);
            this.MenuItemFirst_CSR.Text = "Главное меню";
            // 
            // ToolStripMenuItemDebt_CSR
            // 
            this.ToolStripMenuItemDebt_CSR.Name = "ToolStripMenuItemDebt_CSR";
            this.ToolStripMenuItemDebt_CSR.Size = new System.Drawing.Size(197, 22);
            this.ToolStripMenuItemDebt_CSR.Text = "Задолженности";
            this.ToolStripMenuItemDebt_CSR.Click += new System.EventHandler(this.ToolStripMenuItemDebt_CSR_Click);
            // 
            // ToolStripMenuItemChange_CSR
            // 
            this.ToolStripMenuItemChange_CSR.Name = "ToolStripMenuItemChange_CSR";
            this.ToolStripMenuItemChange_CSR.Size = new System.Drawing.Size(197, 22);
            this.ToolStripMenuItemChange_CSR.Text = "Заселение/выселение";
            this.ToolStripMenuItemChange_CSR.Click += new System.EventHandler(this.ToolStripMenuItemChange_CSR_Click);
            // 
            // ToolStripMenuItemInfo_CSR
            // 
            this.ToolStripMenuItemInfo_CSR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAbout_CSR,
            this.ToolStripMenuItemGuide_CSR});
            this.ToolStripMenuItemInfo_CSR.Name = "ToolStripMenuItemInfo_CSR";
            this.ToolStripMenuItemInfo_CSR.Size = new System.Drawing.Size(161, 20);
            this.ToolStripMenuItemInfo_CSR.Text = "Справочная информация";
            // 
            // ToolStripMenuItemAbout_CSR
            // 
            this.ToolStripMenuItemAbout_CSR.Name = "ToolStripMenuItemAbout_CSR";
            this.ToolStripMenuItemAbout_CSR.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemAbout_CSR.Text = "О программе";
            this.ToolStripMenuItemAbout_CSR.Click += new System.EventHandler(this.ToolStripMenuItemAbout_CSR_Click);
            // 
            // ToolStripMenuItemGuide_CSR
            // 
            this.ToolStripMenuItemGuide_CSR.Name = "ToolStripMenuItemGuide_CSR";
            this.ToolStripMenuItemGuide_CSR.Size = new System.Drawing.Size(221, 22);
            this.ToolStripMenuItemGuide_CSR.Text = "Руководство пользователя";
            this.ToolStripMenuItemGuide_CSR.Click += new System.EventHandler(this.ToolStripMenuItemGuide_CSR_Click);
            // 
            // chartInfo_CSR
            // 
            this.chartInfo_CSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartInfo_CSR.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartInfo_CSR.Legends.Add(legend1);
            this.chartInfo_CSR.Location = new System.Drawing.Point(154, 32);
            this.chartInfo_CSR.Margin = new System.Windows.Forms.Padding(2);
            this.chartInfo_CSR.Name = "chartInfo_CSR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo_CSR.Series.Add(series1);
            this.chartInfo_CSR.Size = new System.Drawing.Size(800, 223);
            this.chartInfo_CSR.TabIndex = 13;
            this.chartInfo_CSR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 531);
            this.Controls.Add(this.chartInfo_CSR);
            this.Controls.Add(this.menuStripAll_CSR);
            this.Controls.Add(this.buttonBack_CSR);
            this.Controls.Add(this.buttonGetDataTable_CSR);
            this.Controls.Add(this.buttonOwnOrRent_CSR);
            this.Controls.Add(this.buttonFlatChart_CSR);
            this.Controls.Add(this.groupBoxFilters_CSR);
            this.Controls.Add(this.groupBoxInfoPeople_CSR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 7 | Чазова С.Р";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxFilters_CSR.ResumeLayout(false);
            this.groupBoxFilters_CSR.PerformLayout();
            this.groupBoxInfoPeople_CSR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfoPeople_CSR)).EndInit();
            this.menuStripAll_CSR.ResumeLayout(false);
            this.menuStripAll_CSR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo_CSR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack_CSR;
        private System.Windows.Forms.Button buttonGetDataTable_CSR;
        private System.Windows.Forms.Button buttonOwnOrRent_CSR;
        private System.Windows.Forms.Button buttonFlatChart_CSR;
        private System.Windows.Forms.GroupBox groupBoxFilters_CSR;
        private System.Windows.Forms.Label labelRenter_CSR;
        private System.Windows.Forms.Button buttonBeginOwn_CSR;
        private System.Windows.Forms.Button buttonbBeginRent_CSR;
        private System.Windows.Forms.Label labelEntrance_CSR;
        private System.Windows.Forms.Button buttonMaxEntrance_CSR;
        private System.Windows.Forms.Button buttonMinEntrance_CSR;
        private System.Windows.Forms.GroupBox groupBoxInfoPeople_CSR;
        private System.Windows.Forms.DataGridView dataGridViewInfoPeople_CSR;
        private System.Windows.Forms.ToolTip toolTipInfo_CSR;
        private System.Windows.Forms.OpenFileDialog openFileDialogGetDataTable_CSR;
        private System.Windows.Forms.MenuStrip menuStripAll_CSR;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFirst_CSR;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDebt_CSR;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemChange_CSR;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInfo_CSR;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_CSR;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGuide_CSR;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo_CSR;
    }
}

