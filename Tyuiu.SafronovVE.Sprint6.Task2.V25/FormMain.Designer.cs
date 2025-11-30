namespace Tyuiu.SafronovVE.Sprint6.Task2.V25
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            labelStopStep = new Label();
            labelStartStep = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxOutput = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult = new Label();
            groupBoxTask.SuspendLayout();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(600, 326);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(588, 294);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxStopStep);
            groupBoxInput.Controls.Add(textBoxStartStep);
            groupBoxInput.Controls.Add(labelStopStep);
            groupBoxInput.Controls.Add(labelStartStep);
            groupBoxInput.Location = new Point(12, 344);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(362, 80);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(192, 46);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(157, 27);
            textBoxStopStep.TabIndex = 3;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 46);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(157, 27);
            textBoxStartStep.TabIndex = 2;
            // 
            // labelStopStep
            // 
            labelStopStep.AutoSize = true;
            labelStopStep.Location = new Point(192, 23);
            labelStopStep.Name = "labelStopStep";
            labelStopStep.Size = new Size(94, 20);
            labelStopStep.TabIndex = 1;
            labelStopStep.Text = "Конец шага:";
            // 
            // labelStartStep
            // 
            labelStartStep.AutoSize = true;
            labelStartStep.Location = new Point(6, 23);
            labelStartStep.Name = "labelStartStep";
            labelStartStep.Size = new Size(88, 20);
            labelStartStep.TabIndex = 0;
            labelStartStep.Text = "Старт шага:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.MenuHighlight;
            buttonHelp.Location = new Point(380, 353);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 71);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.ForestGreen;
            buttonDone.Location = new Point(480, 353);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(132, 71);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(chartFunction);
            groupBoxOutput.Controls.Add(dataGridViewFunction);
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Location = new Point(618, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(659, 409);
            groupBoxOutput.TabIndex = 4;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(199, 46);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(454, 355);
            chartFunction.TabIndex = 2;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction.Location = new Point(6, 46);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(187, 357);
            dataGridViewFunction.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.Width = 50;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(6, 23);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 433);
            Controls.Add(groupBoxOutput);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 25 | Сафронов В.Е.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxInput;
        private Label labelStopStep;
        private Label labelStartStep;
        private TextBox textBoxStartStep;
        private TextBox textBoxStopStep;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBoxOutput;
        private DataGridView dataGridViewFunction;
        private Label labelResult;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
