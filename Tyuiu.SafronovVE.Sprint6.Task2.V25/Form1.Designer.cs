namespace Tyuiu.SafronovVE.Sprint6.Task2.V25
{
    partial class Form1
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
            conditionGroupBox = new GroupBox();
            conditionLabel = new Label();
            inputGroupBox = new GroupBox();
            stopValueLabel = new Label();
            startValueLabel = new Label();
            stopValueText = new TextBox();
            startValueText = new TextBox();
            completeButton = new Button();
            infoButton = new Button();
            resultDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            outputGroupBox = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            resultLabel = new Label();
            conditionGroupBox.SuspendLayout();
            inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            outputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // conditionGroupBox
            // 
            conditionGroupBox.Controls.Add(conditionLabel);
            conditionGroupBox.Location = new Point(12, 12);
            conditionGroupBox.Name = "conditionGroupBox";
            conditionGroupBox.Size = new Size(537, 331);
            conditionGroupBox.TabIndex = 0;
            conditionGroupBox.TabStop = false;
            conditionGroupBox.Text = "Условие";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(6, 23);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(453, 60);
            conditionLabel.TabIndex = 0;
            conditionLabel.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.\r\n\r\n";
            // 
            // inputGroupBox
            // 
            inputGroupBox.Controls.Add(stopValueLabel);
            inputGroupBox.Controls.Add(startValueLabel);
            inputGroupBox.Controls.Add(stopValueText);
            inputGroupBox.Controls.Add(startValueText);
            inputGroupBox.Location = new Point(12, 349);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Size = new Size(272, 89);
            inputGroupBox.TabIndex = 1;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Ввод данных";
            // 
            // stopValueLabel
            // 
            stopValueLabel.AutoSize = true;
            stopValueLabel.Location = new Point(137, 32);
            stopValueLabel.Name = "stopValueLabel";
            stopValueLabel.Size = new Size(94, 20);
            stopValueLabel.TabIndex = 3;
            stopValueLabel.Text = "Конец шага:";
            stopValueLabel.Click += stopValueLabel_Click;
            // 
            // startValueLabel
            // 
            startValueLabel.AutoSize = true;
            startValueLabel.Location = new Point(6, 32);
            startValueLabel.Name = "startValueLabel";
            startValueLabel.Size = new Size(88, 20);
            startValueLabel.TabIndex = 2;
            startValueLabel.Text = "Старт шага:";
            // 
            // stopValueText
            // 
            stopValueText.Location = new Point(137, 55);
            stopValueText.Name = "stopValueText";
            stopValueText.Size = new Size(126, 27);
            stopValueText.TabIndex = 1;
            // 
            // startValueText
            // 
            startValueText.Location = new Point(6, 55);
            startValueText.Name = "startValueText";
            startValueText.Size = new Size(126, 27);
            startValueText.TabIndex = 0;
            // 
            // completeButton
            // 
            completeButton.BackColor = Color.Chartreuse;
            completeButton.Location = new Point(403, 360);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(146, 78);
            completeButton.TabIndex = 2;
            completeButton.Text = "Выполнить";
            completeButton.UseVisualStyleBackColor = false;
            completeButton.Click += completeButton_Click;
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.DodgerBlue;
            infoButton.Location = new Point(290, 360);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(107, 78);
            infoButton.TabIndex = 3;
            infoButton.Text = "Справка";
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            resultDataGridView.Location = new Point(6, 46);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersVisible = false;
            resultDataGridView.RowHeadersWidth = 51;
            resultDataGridView.Size = new Size(188, 373);
            resultDataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.FillWeight = 50F;
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 75;
            // 
            // Column2
            // 
            Column2.FillWeight = 50F;
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 75;
            // 
            // outputGroupBox
            // 
            outputGroupBox.Controls.Add(chartFunction);
            outputGroupBox.Controls.Add(resultLabel);
            outputGroupBox.Controls.Add(resultDataGridView);
            outputGroupBox.Location = new Point(555, 12);
            outputGroupBox.Name = "outputGroupBox";
            outputGroupBox.Size = new Size(660, 426);
            outputGroupBox.TabIndex = 5;
            outputGroupBox.TabStop = false;
            outputGroupBox.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(200, 46);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(452, 373);
            chartFunction.TabIndex = 6;
            chartFunction.Text = "chart1";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(6, 23);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(78, 20);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 450);
            Controls.Add(outputGroupBox);
            Controls.Add(infoButton);
            Controls.Add(completeButton);
            Controls.Add(inputGroupBox);
            Controls.Add(conditionGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 2 | V25 | Safronov V.E.";
            conditionGroupBox.ResumeLayout(false);
            conditionGroupBox.PerformLayout();
            inputGroupBox.ResumeLayout(false);
            inputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            outputGroupBox.ResumeLayout(false);
            outputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox conditionGroupBox;
        private Label conditionLabel;
        private GroupBox inputGroupBox;
        private TextBox stopValueText;
        private TextBox startValueText;
        private Label startValueLabel;
        private Label stopValueLabel;
        private Button completeButton;
        private Button infoButton;
        private DataGridView resultDataGridView;
        private GroupBox outputGroupBox;
        private Label resultLabel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
