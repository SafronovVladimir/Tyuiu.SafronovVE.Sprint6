namespace Tyuiu.SafronovVE.Sprint6.Task4.V6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop_SVE = new Panel();
            buttonHelp_SVE = new Button();
            buttonSave_SVE = new Button();
            buttonDone_SVE = new Button();
            groupBoxInputData_SVE = new GroupBox();
            textBoxStopStep_SVE = new TextBox();
            textBoxStartStep_SVE = new TextBox();
            labelVarB_SVE = new Label();
            labelVarA_SVE = new Label();
            groupBoxTask_SVE = new GroupBox();
            textBoxTask_SVE = new TextBox();
            panelLeft_SVE = new Panel();
            groupBoxOutputData_SVE = new GroupBox();
            textBoxResult_SVE = new TextBox();
            panelFill_SVE = new Panel();
            chartFunction_SVE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterPanel_SVE = new Splitter();
            panelTop_SVE.SuspendLayout();
            groupBoxInputData_SVE.SuspendLayout();
            groupBoxTask_SVE.SuspendLayout();
            panelLeft_SVE.SuspendLayout();
            groupBoxOutputData_SVE.SuspendLayout();
            panelFill_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SVE).BeginInit();
            SuspendLayout();
            // 
            // panelTop_SVE
            // 
            panelTop_SVE.BorderStyle = BorderStyle.FixedSingle;
            panelTop_SVE.Controls.Add(buttonHelp_SVE);
            panelTop_SVE.Controls.Add(buttonSave_SVE);
            panelTop_SVE.Controls.Add(buttonDone_SVE);
            panelTop_SVE.Controls.Add(groupBoxInputData_SVE);
            panelTop_SVE.Controls.Add(groupBoxTask_SVE);
            panelTop_SVE.Dock = DockStyle.Top;
            panelTop_SVE.Location = new Point(0, 0);
            panelTop_SVE.Name = "panelTop_SVE";
            panelTop_SVE.Size = new Size(1279, 110);
            panelTop_SVE.TabIndex = 0;
            // 
            // buttonHelp_SVE
            // 
            buttonHelp_SVE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SVE.BackColor = Color.RoyalBlue;
            buttonHelp_SVE.Location = new Point(1159, 11);
            buttonHelp_SVE.Name = "buttonHelp_SVE";
            buttonHelp_SVE.Size = new Size(108, 92);
            buttonHelp_SVE.TabIndex = 1;
            buttonHelp_SVE.Text = "Справка";
            buttonHelp_SVE.UseVisualStyleBackColor = false;
            buttonHelp_SVE.Click += buttonHelp_SVE_Click;
            buttonHelp_SVE.MouseEnter += buttonDone_SVE_MouseEnter;
            buttonHelp_SVE.MouseLeave += buttonDone_SVE_MouseLeave;
            // 
            // buttonSave_SVE
            // 
            buttonSave_SVE.BackColor = Color.MediumSlateBlue;
            buttonSave_SVE.Location = new Point(1045, 11);
            buttonSave_SVE.Name = "buttonSave_SVE";
            buttonSave_SVE.Size = new Size(108, 92);
            buttonSave_SVE.TabIndex = 1;
            buttonSave_SVE.Text = "Сохранить";
            buttonSave_SVE.UseVisualStyleBackColor = false;
            buttonSave_SVE.Click += buttonSave_SVE_Click;
            buttonSave_SVE.MouseEnter += buttonDone_SVE_MouseEnter;
            buttonSave_SVE.MouseLeave += buttonDone_SVE_MouseLeave;
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.BackColor = Color.Green;
            buttonDone_SVE.Location = new Point(931, 11);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(108, 93);
            buttonDone_SVE.TabIndex = 1;
            buttonDone_SVE.Text = "Выполнить";
            buttonDone_SVE.UseVisualStyleBackColor = false;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            buttonDone_SVE.MouseEnter += buttonDone_SVE_MouseEnter;
            buttonDone_SVE.MouseLeave += buttonDone_SVE_MouseLeave;
            // 
            // groupBoxInputData_SVE
            // 
            groupBoxInputData_SVE.Controls.Add(textBoxStopStep_SVE);
            groupBoxInputData_SVE.Controls.Add(textBoxStartStep_SVE);
            groupBoxInputData_SVE.Controls.Add(labelVarB_SVE);
            groupBoxInputData_SVE.Controls.Add(labelVarA_SVE);
            groupBoxInputData_SVE.Location = new Point(575, 3);
            groupBoxInputData_SVE.Name = "groupBoxInputData_SVE";
            groupBoxInputData_SVE.Size = new Size(344, 101);
            groupBoxInputData_SVE.TabIndex = 0;
            groupBoxInputData_SVE.TabStop = false;
            groupBoxInputData_SVE.Text = "Ввод данных:";
            // 
            // textBoxStopStep_SVE
            // 
            textBoxStopStep_SVE.Location = new Point(177, 46);
            textBoxStopStep_SVE.Name = "textBoxStopStep_SVE";
            textBoxStopStep_SVE.Size = new Size(161, 27);
            textBoxStopStep_SVE.TabIndex = 1;
            // 
            // textBoxStartStep_SVE
            // 
            textBoxStartStep_SVE.Location = new Point(6, 46);
            textBoxStartStep_SVE.Name = "textBoxStartStep_SVE";
            textBoxStartStep_SVE.Size = new Size(161, 27);
            textBoxStartStep_SVE.TabIndex = 1;
            // 
            // labelVarB_SVE
            // 
            labelVarB_SVE.AutoSize = true;
            labelVarB_SVE.Location = new Point(177, 23);
            labelVarB_SVE.Name = "labelVarB_SVE";
            labelVarB_SVE.Size = new Size(94, 20);
            labelVarB_SVE.TabIndex = 0;
            labelVarB_SVE.Text = "Конец шага:";
            // 
            // labelVarA_SVE
            // 
            labelVarA_SVE.AutoSize = true;
            labelVarA_SVE.Location = new Point(6, 23);
            labelVarA_SVE.Name = "labelVarA_SVE";
            labelVarA_SVE.Size = new Size(88, 20);
            labelVarA_SVE.TabIndex = 0;
            labelVarA_SVE.Text = "Старт шага:";
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Location = new Point(12, 3);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(557, 101);
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
            textBoxTask_SVE.Size = new Size(545, 60);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox,  построить график функции и сохранить в файл\r\nOutPutFile.txt по нажатию кнопки.";
            // 
            // panelLeft_SVE
            // 
            panelLeft_SVE.Controls.Add(groupBoxOutputData_SVE);
            panelLeft_SVE.Dock = DockStyle.Left;
            panelLeft_SVE.Location = new Point(0, 110);
            panelLeft_SVE.Name = "panelLeft_SVE";
            panelLeft_SVE.Size = new Size(390, 598);
            panelLeft_SVE.TabIndex = 1;
            // 
            // groupBoxOutputData_SVE
            // 
            groupBoxOutputData_SVE.Controls.Add(textBoxResult_SVE);
            groupBoxOutputData_SVE.Dock = DockStyle.Fill;
            groupBoxOutputData_SVE.Location = new Point(0, 0);
            groupBoxOutputData_SVE.Name = "groupBoxOutputData_SVE";
            groupBoxOutputData_SVE.Size = new Size(390, 598);
            groupBoxOutputData_SVE.TabIndex = 0;
            groupBoxOutputData_SVE.TabStop = false;
            groupBoxOutputData_SVE.Text = "Вывод:";
            // 
            // textBoxResult_SVE
            // 
            textBoxResult_SVE.Dock = DockStyle.Fill;
            textBoxResult_SVE.Location = new Point(3, 23);
            textBoxResult_SVE.Multiline = true;
            textBoxResult_SVE.Name = "textBoxResult_SVE";
            textBoxResult_SVE.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SVE.Size = new Size(384, 572);
            textBoxResult_SVE.TabIndex = 0;
            // 
            // panelFill_SVE
            // 
            panelFill_SVE.Controls.Add(chartFunction_SVE);
            panelFill_SVE.Dock = DockStyle.Fill;
            panelFill_SVE.Location = new Point(390, 110);
            panelFill_SVE.Name = "panelFill_SVE";
            panelFill_SVE.Size = new Size(889, 598);
            panelFill_SVE.TabIndex = 2;
            // 
            // chartFunction_SVE
            // 
            chartArea2.Name = "ChartArea1";
            chartFunction_SVE.ChartAreas.Add(chartArea2);
            chartFunction_SVE.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartFunction_SVE.Legends.Add(legend2);
            chartFunction_SVE.Location = new Point(0, 0);
            chartFunction_SVE.Name = "chartFunction_SVE";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunction_SVE.Series.Add(series2);
            chartFunction_SVE.Size = new Size(889, 598);
            chartFunction_SVE.TabIndex = 1;
            chartFunction_SVE.Text = "График функции ";
            title2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title2.ForeColor = Color.RoyalBlue;
            title2.Name = "Title";
            title2.Text = "График функции";
            chartFunction_SVE.Titles.Add(title2);
            // 
            // splitterPanel_SVE
            // 
            splitterPanel_SVE.Location = new Point(390, 110);
            splitterPanel_SVE.Name = "splitterPanel_SVE";
            splitterPanel_SVE.Size = new Size(4, 598);
            splitterPanel_SVE.TabIndex = 3;
            splitterPanel_SVE.TabStop = false;
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 708);
            Controls.Add(splitterPanel_SVE);
            Controls.Add(panelFill_SVE);
            Controls.Add(panelLeft_SVE);
            Controls.Add(panelTop_SVE);
            Name = "FormMain_SVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 6 | Сафронов В. Е.";
            panelTop_SVE.ResumeLayout(false);
            groupBoxInputData_SVE.ResumeLayout(false);
            groupBoxInputData_SVE.PerformLayout();
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            panelLeft_SVE.ResumeLayout(false);
            groupBoxOutputData_SVE.ResumeLayout(false);
            groupBoxOutputData_SVE.PerformLayout();
            panelFill_SVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_SVE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_SVE;
        private Panel panelLeft_SVE;
        private Panel panelFill_SVE;
        private GroupBox groupBoxTask_SVE;
        private TextBox textBoxTask_SVE;
        private GroupBox groupBoxInputData_SVE;
        private TextBox textBoxStopStep_SVE;
        private TextBox textBoxStartStep_SVE;
        private Label labelVarB_SVE;
        private Label labelVarA_SVE;
        private Button buttonHelp_SVE;
        private Button buttonSave_SVE;
        private Button buttonDone_SVE;
        private GroupBox groupBoxOutputData_SVE;
        private TextBox textBoxResult_SVE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVE;
        private Splitter splitterPanel_SVE;
    }
}
