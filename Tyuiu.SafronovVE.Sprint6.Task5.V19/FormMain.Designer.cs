namespace Tyuiu.SafronovVE.Sprint6.Task5.V19
{
    partial class FormMain_SVE
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTop_SVE = new Panel();
            buttonHelp_SVE = new Button();
            buttonSave_SVE = new Button();
            buttonDone_SVE = new Button();
            groupBoxTask_SVE = new GroupBox();
            textBoxTask_SVE = new TextBox();
            panelLeft_SVE = new Panel();
            groupBoxOutputData_SVE = new GroupBox();
            dataGridViewNums_SVE = new DataGridView();
            splitterPanel_SVE = new Splitter();
            panelRight_SVE = new Panel();
            chartDiag_SVE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTop_SVE.SuspendLayout();
            groupBoxTask_SVE.SuspendLayout();
            panelLeft_SVE.SuspendLayout();
            groupBoxOutputData_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_SVE).BeginInit();
            panelRight_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_SVE).BeginInit();
            SuspendLayout();
            // 
            // panelTop_SVE
            // 
            panelTop_SVE.BorderStyle = BorderStyle.FixedSingle;
            panelTop_SVE.Controls.Add(buttonHelp_SVE);
            panelTop_SVE.Controls.Add(buttonSave_SVE);
            panelTop_SVE.Controls.Add(buttonDone_SVE);
            panelTop_SVE.Controls.Add(groupBoxTask_SVE);
            panelTop_SVE.Dock = DockStyle.Top;
            panelTop_SVE.Location = new Point(0, 0);
            panelTop_SVE.Name = "panelTop_SVE";
            panelTop_SVE.Size = new Size(896, 106);
            panelTop_SVE.TabIndex = 0;
            // 
            // buttonHelp_SVE
            // 
            buttonHelp_SVE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SVE.BackColor = Color.RoyalBlue;
            buttonHelp_SVE.Location = new Point(782, 11);
            buttonHelp_SVE.Name = "buttonHelp_SVE";
            buttonHelp_SVE.Size = new Size(105, 88);
            buttonHelp_SVE.TabIndex = 1;
            buttonHelp_SVE.Text = "Справка";
            buttonHelp_SVE.UseVisualStyleBackColor = false;
            buttonHelp_SVE.Click += buttonHelp_SVE_Click;
            buttonHelp_SVE.MouseEnter += buttonDone_SVE_MouseEnter;
            buttonHelp_SVE.MouseLeave += buttonDone_SVE_MouseLeave;
            // 
            // buttonSave_SVE
            // 
            buttonSave_SVE.BackColor = Color.SlateBlue;
            buttonSave_SVE.Location = new Point(671, 11);
            buttonSave_SVE.Name = "buttonSave_SVE";
            buttonSave_SVE.Size = new Size(105, 88);
            buttonSave_SVE.TabIndex = 1;
            buttonSave_SVE.Text = "Открыть файл";
            buttonSave_SVE.UseVisualStyleBackColor = false;
            buttonSave_SVE.Click += buttonSave_SVE_Click;
            buttonSave_SVE.MouseEnter += buttonDone_SVE_MouseEnter;
            buttonSave_SVE.MouseLeave += buttonDone_SVE_MouseLeave;
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.BackColor = Color.Green;
            buttonDone_SVE.Location = new Point(560, 11);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(105, 88);
            buttonDone_SVE.TabIndex = 1;
            buttonDone_SVE.Text = "Выполнить";
            buttonDone_SVE.UseVisualStyleBackColor = false;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            buttonDone_SVE.MouseEnter += buttonDone_SVE_MouseEnter;
            buttonDone_SVE.MouseLeave += buttonDone_SVE_MouseLeave;
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Location = new Point(4, 3);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(550, 96);
            groupBoxTask_SVE.TabIndex = 0;
            groupBoxTask_SVE.TabStop = false;
            groupBoxTask_SVE.Text = "Условие:";
            // 
            // textBoxTask_SVE
            // 
            textBoxTask_SVE.BorderStyle = BorderStyle.None;
            textBoxTask_SVE.Location = new Point(6, 26);
            textBoxTask_SVE.Multiline = true;
            textBoxTask_SVE.Name = "textBoxTask_SVE";
            textBoxTask_SVE.ReadOnly = true;
            textBoxTask_SVE.Size = new Size(524, 58);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = "Прочитать данные из файла InPutFileTask5V19.txt. Вывести в dataGridView.\r\nВывести все целые числа. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_SVE
            // 
            panelLeft_SVE.Controls.Add(groupBoxOutputData_SVE);
            panelLeft_SVE.Dock = DockStyle.Left;
            panelLeft_SVE.Location = new Point(0, 106);
            panelLeft_SVE.Name = "panelLeft_SVE";
            panelLeft_SVE.Size = new Size(250, 450);
            panelLeft_SVE.TabIndex = 1;
            // 
            // groupBoxOutputData_SVE
            // 
            groupBoxOutputData_SVE.Controls.Add(dataGridViewNums_SVE);
            groupBoxOutputData_SVE.Dock = DockStyle.Fill;
            groupBoxOutputData_SVE.Location = new Point(0, 0);
            groupBoxOutputData_SVE.Name = "groupBoxOutputData_SVE";
            groupBoxOutputData_SVE.Size = new Size(250, 450);
            groupBoxOutputData_SVE.TabIndex = 0;
            groupBoxOutputData_SVE.TabStop = false;
            groupBoxOutputData_SVE.Text = "Вывод данных:";
            // 
            // dataGridViewNums_SVE
            // 
            dataGridViewNums_SVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_SVE.Dock = DockStyle.Fill;
            dataGridViewNums_SVE.Location = new Point(3, 23);
            dataGridViewNums_SVE.Name = "dataGridViewNums_SVE";
            dataGridViewNums_SVE.RowHeadersVisible = false;
            dataGridViewNums_SVE.RowHeadersWidth = 51;
            dataGridViewNums_SVE.Size = new Size(244, 424);
            dataGridViewNums_SVE.TabIndex = 0;
            // 
            // splitterPanel_SVE
            // 
            splitterPanel_SVE.Location = new Point(250, 106);
            splitterPanel_SVE.Name = "splitterPanel_SVE";
            splitterPanel_SVE.Size = new Size(10, 450);
            splitterPanel_SVE.TabIndex = 2;
            splitterPanel_SVE.TabStop = false;
            // 
            // panelRight_SVE
            // 
            panelRight_SVE.Controls.Add(chartDiag_SVE);
            panelRight_SVE.Dock = DockStyle.Fill;
            panelRight_SVE.Location = new Point(260, 106);
            panelRight_SVE.Name = "panelRight_SVE";
            panelRight_SVE.Size = new Size(636, 450);
            panelRight_SVE.TabIndex = 3;
            // 
            // chartDiag_SVE
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_SVE.ChartAreas.Add(chartArea1);
            chartDiag_SVE.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag_SVE.Legends.Add(legend1);
            chartDiag_SVE.Location = new Point(0, 0);
            chartDiag_SVE.Name = "chartDiag_SVE";
            chartDiag_SVE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_SVE.Series.Add(series1);
            chartDiag_SVE.Size = new Size(636, 450);
            chartDiag_SVE.TabIndex = 0;
            chartDiag_SVE.Text = "chart1";
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 556);
            Controls.Add(panelRight_SVE);
            Controls.Add(splitterPanel_SVE);
            Controls.Add(panelLeft_SVE);
            Controls.Add(panelTop_SVE);
            Name = "FormMain_SVE";
            Text = "Спринт 6 | Таск 5 | Вариант 19 | Сафронов В. Е.";
            Load += FormMain_SVE_Load;
            panelTop_SVE.ResumeLayout(false);
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            panelLeft_SVE.ResumeLayout(false);
            groupBoxOutputData_SVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_SVE).EndInit();
            panelRight_SVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_SVE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_SVE;
        private GroupBox groupBoxTask_SVE;
        private TextBox textBoxTask_SVE;
        private Panel panelLeft_SVE;
        private Splitter splitterPanel_SVE;
        private Panel panelRight_SVE;
        private Button buttonHelp_SVE;
        private Button buttonSave_SVE;
        private Button buttonDone_SVE;
        private GroupBox groupBoxOutputData_SVE;
        private DataGridView dataGridViewNums_SVE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SVE;
    }
}
