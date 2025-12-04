namespace Tyuiu.SafronovVE.Sprint6.Task4.V6
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panelTop = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            groupBoxInputData = new GroupBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            labelVarB = new Label();
            labelVarA = new Label();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            panelLeft = new Panel();
            groupBoxOutputData = new GroupBox();
            textBoxResult = new TextBox();
            panelFill = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitterPanel = new Splitter();
            panelTop.SuspendLayout();
            groupBoxInputData.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxOutputData.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonSave);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(groupBoxInputData);
            panelTop.Controls.Add(groupBoxTask);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1279, 110);
            panelTop.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = Color.RoyalBlue;
            buttonHelp.Location = new Point(1159, 11);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(108, 92);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            buttonHelp.MouseEnter += buttonDone_MouseEnter;
            buttonHelp.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.MediumSlateBlue;
            buttonSave.Location = new Point(1045, 11);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(108, 92);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            buttonSave.MouseEnter += buttonDone_MouseEnter;
            buttonSave.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(931, 11);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(108, 93);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBoxInputData
            // 
            groupBoxInputData.Controls.Add(textBoxStopStep);
            groupBoxInputData.Controls.Add(textBoxStartStep);
            groupBoxInputData.Controls.Add(labelVarB);
            groupBoxInputData.Controls.Add(labelVarA);
            groupBoxInputData.Location = new Point(575, 3);
            groupBoxInputData.Name = "groupBoxInputData";
            groupBoxInputData.Size = new Size(344, 101);
            groupBoxInputData.TabIndex = 0;
            groupBoxInputData.TabStop = false;
            groupBoxInputData.Text = "Ввод данных:";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(177, 46);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(161, 27);
            textBoxStopStep.TabIndex = 1;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 46);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(161, 27);
            textBoxStartStep.TabIndex = 1;
            // 
            // labelVarB
            // 
            labelVarB.AutoSize = true;
            labelVarB.Location = new Point(177, 23);
            labelVarB.Name = "labelVarB";
            labelVarB.Size = new Size(94, 20);
            labelVarB.TabIndex = 0;
            labelVarB.Text = "Конец шага:";
            // 
            // labelVarA
            // 
            labelVarA.AutoSize = true;
            labelVarA.Location = new Point(6, 23);
            labelVarA.Name = "labelVarA";
            labelVarA.Size = new Size(88, 20);
            labelVarA.TabIndex = 0;
            labelVarA.Text = "Старт шага:";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 3);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(557, 101);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(545, 60);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox,  построить график функции и сохранить в файл\r\nOutPutFile.txt по нажатию кнопки.";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxOutputData);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 110);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(390, 598);
            panelLeft.TabIndex = 1;
            // 
            // groupBoxOutputData
            // 
            groupBoxOutputData.Controls.Add(textBoxResult);
            groupBoxOutputData.Dock = DockStyle.Fill;
            groupBoxOutputData.Location = new Point(0, 0);
            groupBoxOutputData.Name = "groupBoxOutputData";
            groupBoxOutputData.Size = new Size(390, 598);
            groupBoxOutputData.TabIndex = 0;
            groupBoxOutputData.TabStop = false;
            groupBoxOutputData.Text = "Вывод:";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 23);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(384, 572);
            textBoxResult.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(chartFunction);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(390, 110);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(889, 598);
            panelFill.TabIndex = 2;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(0, 0);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(889, 598);
            chartFunction.TabIndex = 1;
            chartFunction.Text = "График функции ";
            title1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.RoyalBlue;
            title1.Name = "Title";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // splitterPanel
            // 
            splitterPanel.Location = new Point(390, 110);
            splitterPanel.Name = "splitterPanel";
            splitterPanel.Size = new Size(4, 598);
            splitterPanel.TabIndex = 3;
            splitterPanel.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 708);
            Controls.Add(splitterPanel);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 6 | Сафронов В. Е.";
            panelTop.ResumeLayout(false);
            groupBoxInputData.ResumeLayout(false);
            groupBoxInputData.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxOutputData.ResumeLayout(false);
            groupBoxOutputData.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelFill;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxInputData;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private Label labelVarB;
        private Label labelVarA;
        private Button buttonHelp;
        private Button buttonSave;
        private Button buttonDone;
        private GroupBox groupBoxOutputData;
        private TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Splitter splitterPanel;
    }
}
