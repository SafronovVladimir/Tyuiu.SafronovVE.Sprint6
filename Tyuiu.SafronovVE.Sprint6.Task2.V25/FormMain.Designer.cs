namespace Tyuiu.SafronovVE.Sprint6.Task2.V25
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
            groupBoxTask_SVE = new GroupBox();
            textBoxTask_SVE = new TextBox();
            groupBoxInput_SVE = new GroupBox();
            textBoxStopStep_SVE = new TextBox();
            textBoxStartStep_SVE = new TextBox();
            labelStopStep_SVE = new Label();
            labelStartStep_SVE = new Label();
            buttonHelp_SVE = new Button();
            buttonDone_SVE = new Button();
            groupBoxOutput_SVE = new GroupBox();
            chartFunction_SVE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_SVE = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            labelResult_SVE = new Label();
            groupBoxTask_SVE.SuspendLayout();
            groupBoxInput_SVE.SuspendLayout();
            groupBoxOutput_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SVE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_SVE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Location = new Point(12, 12);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(600, 326);
            groupBoxTask_SVE.TabIndex = 0;
            groupBoxTask_SVE.TabStop = false;
            groupBoxTask_SVE.Text = "Условие";
            // 
            // textBoxTask_SVE
            // 
            textBoxTask_SVE.BackColor = SystemColors.Control;
            textBoxTask_SVE.BorderStyle = BorderStyle.None;
            textBoxTask_SVE.Location = new Point(6, 26);
            textBoxTask_SVE.Multiline = true;
            textBoxTask_SVE.Name = "textBoxTask_SVE";
            textBoxTask_SVE.ReadOnly = true;
            textBoxTask_SVE.Size = new Size(588, 294);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_SVE
            // 
            groupBoxInput_SVE.Controls.Add(textBoxStopStep_SVE);
            groupBoxInput_SVE.Controls.Add(textBoxStartStep_SVE);
            groupBoxInput_SVE.Controls.Add(labelStopStep_SVE);
            groupBoxInput_SVE.Controls.Add(labelStartStep_SVE);
            groupBoxInput_SVE.Location = new Point(12, 344);
            groupBoxInput_SVE.Name = "groupBoxInput_SVE";
            groupBoxInput_SVE.Size = new Size(362, 80);
            groupBoxInput_SVE.TabIndex = 1;
            groupBoxInput_SVE.TabStop = false;
            groupBoxInput_SVE.Text = "Ввод данных";
            // 
            // textBoxStopStep_SVE
            // 
            textBoxStopStep_SVE.Location = new Point(192, 46);
            textBoxStopStep_SVE.Name = "textBoxStopStep_SVE";
            textBoxStopStep_SVE.Size = new Size(157, 27);
            textBoxStopStep_SVE.TabIndex = 3;
            // 
            // textBoxStartStep_SVE
            // 
            textBoxStartStep_SVE.Location = new Point(6, 46);
            textBoxStartStep_SVE.Name = "textBoxStartStep_SVE";
            textBoxStartStep_SVE.Size = new Size(157, 27);
            textBoxStartStep_SVE.TabIndex = 2;
            // 
            // labelStopStep_SVE
            // 
            labelStopStep_SVE.AutoSize = true;
            labelStopStep_SVE.Location = new Point(192, 23);
            labelStopStep_SVE.Name = "labelStopStep_SVE";
            labelStopStep_SVE.Size = new Size(94, 20);
            labelStopStep_SVE.TabIndex = 1;
            labelStopStep_SVE.Text = "Конец шага:";
            // 
            // labelStartStep_SVE
            // 
            labelStartStep_SVE.AutoSize = true;
            labelStartStep_SVE.Location = new Point(6, 23);
            labelStartStep_SVE.Name = "labelStartStep_SVE";
            labelStartStep_SVE.Size = new Size(88, 20);
            labelStartStep_SVE.TabIndex = 0;
            labelStartStep_SVE.Text = "Старт шага:";
            // 
            // buttonHelp_SVE
            // 
            buttonHelp_SVE.BackColor = SystemColors.MenuHighlight;
            buttonHelp_SVE.Location = new Point(380, 353);
            buttonHelp_SVE.Name = "buttonHelp_SVE";
            buttonHelp_SVE.Size = new Size(94, 71);
            buttonHelp_SVE.TabIndex = 2;
            buttonHelp_SVE.Text = "Справка";
            buttonHelp_SVE.UseVisualStyleBackColor = false;
            buttonHelp_SVE.Click += buttonHelp_SVE_Click;
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.BackColor = Color.ForestGreen;
            buttonDone_SVE.Location = new Point(480, 353);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(132, 71);
            buttonDone_SVE.TabIndex = 3;
            buttonDone_SVE.Text = "Выполнить";
            buttonDone_SVE.UseVisualStyleBackColor = false;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            buttonDone_SVE.MouseDown += buttonDone_SVE_MouseDown;
            buttonDone_SVE.MouseEnter += buttonDone_SVE_MouseEnter;
            buttonDone_SVE.MouseLeave += buttonDone_SVE_MouseLeave;
            // 
            // groupBoxOutput_SVE
            // 
            groupBoxOutput_SVE.Controls.Add(chartFunction_SVE);
            groupBoxOutput_SVE.Controls.Add(dataGridViewFunction_SVE);
            groupBoxOutput_SVE.Controls.Add(labelResult_SVE);
            groupBoxOutput_SVE.Location = new Point(618, 12);
            groupBoxOutput_SVE.Name = "groupBoxOutput_SVE";
            groupBoxOutput_SVE.Size = new Size(659, 409);
            groupBoxOutput_SVE.TabIndex = 4;
            groupBoxOutput_SVE.TabStop = false;
            groupBoxOutput_SVE.Text = "Вывод данных";
            // 
            // chartFunction_SVE
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_SVE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_SVE.Legends.Add(legend1);
            chartFunction_SVE.Location = new Point(199, 46);
            chartFunction_SVE.Name = "chartFunction_SVE";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_SVE.Series.Add(series1);
            chartFunction_SVE.Size = new Size(454, 355);
            chartFunction_SVE.TabIndex = 2;
            chartFunction_SVE.Text = "chart1";
            // 
            // dataGridViewFunction_SVE
            // 
            dataGridViewFunction_SVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_SVE.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_SVE.Location = new Point(6, 46);
            dataGridViewFunction_SVE.Name = "dataGridViewFunction_SVE";
            dataGridViewFunction_SVE.ReadOnly = true;
            dataGridViewFunction_SVE.RowHeadersVisible = false;
            dataGridViewFunction_SVE.RowHeadersWidth = 51;
            dataGridViewFunction_SVE.Size = new Size(187, 357);
            dataGridViewFunction_SVE.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.MinimumWidth = 6;
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 50;
            // 
            // labelResult_SVE
            // 
            labelResult_SVE.AutoSize = true;
            labelResult_SVE.Location = new Point(6, 23);
            labelResult_SVE.Name = "labelResult_SVE";
            labelResult_SVE.Size = new Size(78, 20);
            labelResult_SVE.TabIndex = 0;
            labelResult_SVE.Text = "Результат:";
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1289, 433);
            Controls.Add(groupBoxOutput_SVE);
            Controls.Add(buttonDone_SVE);
            Controls.Add(buttonHelp_SVE);
            Controls.Add(groupBoxInput_SVE);
            Controls.Add(groupBoxTask_SVE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_SVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 25 | Сафронов В. Е.";
            Load += FormMain_SVE_Load;
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            groupBoxInput_SVE.ResumeLayout(false);
            groupBoxInput_SVE.PerformLayout();
            groupBoxOutput_SVE.ResumeLayout(false);
            groupBoxOutput_SVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SVE).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_SVE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SVE;
        private TextBox textBoxTask_SVE;
        private GroupBox groupBoxInput_SVE;
        private Label labelStopStep_SVE;
        private Label labelStartStep_SVE;
        private TextBox textBoxStartStep_SVE;
        private TextBox textBoxStopStep_SVE;
        private Button buttonHelp_SVE;
        private Button buttonDone_SVE;
        private GroupBox groupBoxOutput_SVE;
        private DataGridView dataGridViewFunction_SVE;
        private Label labelResult_SVE;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVE;
    }
}
