using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SafronovVE.Sprint6.Task4.V6
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            Title title1 = new Title();
            conditionGroupBox = new GroupBox();
            conditionLabel = new Label();
            inputDataGroupBox = new GroupBox();
            stopStep = new TextBox();
            startStep = new TextBox();
            stopStepLabel = new Label();
            startStepLabel = new Label();
            doneButton = new Button();
            saveButton = new Button();
            inputDataLabel = new Label();
            outputTextBox = new TextBox();
            chartFunction = new Chart();
            infoButton = new Button();
            panel1 = new Panel();
            conditionGroupBox.SuspendLayout();
            inputDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // conditionGroupBox
            // 
            conditionGroupBox.Controls.Add(conditionLabel);
            conditionGroupBox.Location = new Point(6, 12);
            conditionGroupBox.Name = "conditionGroupBox";
            conditionGroupBox.Size = new Size(561, 88);
            conditionGroupBox.TabIndex = 0;
            conditionGroupBox.TabStop = false;
            conditionGroupBox.Text = "Условие";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(18, 23);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(542, 80);
            conditionLabel.TabIndex = 0;
            conditionLabel.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox,  построить график функции и сохранить в файл\r\nOutPutFile.txt по нажатию кнопки.\r\n\r\n";
            // 
            // inputDataGroupBox
            // 
            inputDataGroupBox.Controls.Add(stopStep);
            inputDataGroupBox.Controls.Add(startStep);
            inputDataGroupBox.Controls.Add(stopStepLabel);
            inputDataGroupBox.Controls.Add(startStepLabel);
            inputDataGroupBox.Location = new Point(573, 12);
            inputDataGroupBox.Name = "inputDataGroupBox";
            inputDataGroupBox.Size = new Size(231, 88);
            inputDataGroupBox.TabIndex = 1;
            inputDataGroupBox.TabStop = false;
            inputDataGroupBox.Text = "Ввод данных";
            // 
            // stopStep
            // 
            stopStep.Location = new Point(119, 46);
            stopStep.Name = "stopStep";
            stopStep.Size = new Size(94, 27);
            stopStep.TabIndex = 3;
            // 
            // startStep
            // 
            startStep.Location = new Point(6, 46);
            startStep.Name = "startStep";
            startStep.Size = new Size(88, 27);
            startStep.TabIndex = 2;
            startStep.TextChanged += startStep_TextChanged;
            // 
            // stopStepLabel
            // 
            stopStepLabel.AutoSize = true;
            stopStepLabel.Location = new Point(119, 23);
            stopStepLabel.Name = "stopStepLabel";
            stopStepLabel.Size = new Size(94, 20);
            stopStepLabel.TabIndex = 1;
            stopStepLabel.Text = "Конец шага:";
            // 
            // startStepLabel
            // 
            startStepLabel.AutoSize = true;
            startStepLabel.Location = new Point(6, 23);
            startStepLabel.Name = "startStepLabel";
            startStepLabel.Size = new Size(88, 20);
            startStepLabel.TabIndex = 0;
            startStepLabel.Text = "Старт шага:";
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.LimeGreen;
            doneButton.Location = new Point(823, 24);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(99, 76);
            doneButton.TabIndex = 2;
            doneButton.Text = "Выполнить";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(128, 128, 255);
            saveButton.Location = new Point(941, 24);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(99, 76);
            saveButton.TabIndex = 3;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // inputDataLabel
            // 
            inputDataLabel.AutoSize = true;
            inputDataLabel.Location = new Point(6, 116);
            inputDataLabel.Name = "inputDataLabel";
            inputDataLabel.Size = new Size(113, 20);
            inputDataLabel.TabIndex = 4;
            inputDataLabel.Text = "Вывод данных:";
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(0, 139);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(264, 454);
            outputTextBox.TabIndex = 5;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(262, 116);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(951, 465);
            chartFunction.TabIndex = 7;
            chartFunction.Text = "График функции";
            title1.Font = new Font("Microsoft Sans Serif", 16F);
            title1.ForeColor = Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction.Titles.Add(title1);
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.FromArgb(0, 192, 192);
            infoButton.Location = new Point(1059, 24);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(99, 76);
            infoButton.TabIndex = 8;
            infoButton.Text = "Сведения";
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 113);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 593);
            Controls.Add(infoButton);
            Controls.Add(chartFunction);
            Controls.Add(outputTextBox);
            Controls.Add(inputDataLabel);
            Controls.Add(saveButton);
            Controls.Add(doneButton);
            Controls.Add(inputDataGroupBox);
            Controls.Add(conditionGroupBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Sprint 6 | Task 4 | V6 | Safronov V.E.";
            Load += Form1_Load;
            conditionGroupBox.ResumeLayout(false);
            conditionGroupBox.PerformLayout();
            inputDataGroupBox.ResumeLayout(false);
            inputDataGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox conditionGroupBox;
        private Label conditionLabel;
        private GroupBox inputDataGroupBox;
        private Label startStepLabel;
        private TextBox stopStep;
        private TextBox startStep;
        private Label stopStepLabel;
        private Button doneButton;
        private Button saveButton;
        private Label inputDataLabel;
        private TextBox outputTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private Button infoButton;
        private Panel panel1;
    }
}
