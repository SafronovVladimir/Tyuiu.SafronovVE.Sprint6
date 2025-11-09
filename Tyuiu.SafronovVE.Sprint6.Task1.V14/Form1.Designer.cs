namespace Tyuiu.SafronovVE.Sprint6.Task1.V14
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
            conditionBox = new GroupBox();
            conditionText2 = new Label();
            conditionText = new Label();
            outputBox = new GroupBox();
            outputText = new Label();
            resultsTextBox = new TextBox();
            inputBox = new GroupBox();
            stopValueText = new Label();
            stopValue = new TextBox();
            startValue = new TextBox();
            startValueText = new Label();
            completeButton = new Button();
            infoButton = new Button();
            conditionBox.SuspendLayout();
            outputBox.SuspendLayout();
            inputBox.SuspendLayout();
            SuspendLayout();
            // 
            // conditionBox
            // 
            conditionBox.Controls.Add(conditionText2);
            conditionBox.Controls.Add(conditionText);
            conditionBox.Location = new Point(12, 12);
            conditionBox.Name = "conditionBox";
            conditionBox.Size = new Size(577, 331);
            conditionBox.TabIndex = 0;
            conditionBox.TabStop = false;
            conditionBox.Text = "Условие";
            // 
            // conditionText2
            // 
            conditionText2.AutoSize = true;
            conditionText2.Location = new Point(13, 57);
            conditionText2.Name = "conditionText2";
            conditionText2.Size = new Size(252, 20);
            conditionText2.TabIndex = 1;
            conditionText2.Text = "Результат вывести в виде таблицы.";
            // 
            // conditionText
            // 
            conditionText.AutoSize = true;
            conditionText.Location = new Point(13, 36);
            conditionText.Name = "conditionText";
            conditionText.Size = new Size(376, 20);
            conditionText.TabIndex = 0;
            conditionText.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // outputBox
            // 
            outputBox.Controls.Add(outputText);
            outputBox.Controls.Add(resultsTextBox);
            outputBox.Location = new Point(595, 12);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(348, 426);
            outputBox.TabIndex = 1;
            outputBox.TabStop = false;
            outputBox.Text = "Вывод данных";
            // 
            // outputText
            // 
            outputText.AutoSize = true;
            outputText.Location = new Point(6, 23);
            outputText.Name = "outputText";
            outputText.Size = new Size(78, 20);
            outputText.TabIndex = 1;
            outputText.Text = "Результат:";
            // 
            // resultsTextBox
            // 
            resultsTextBox.Location = new Point(6, 49);
            resultsTextBox.Multiline = true;
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.Size = new Size(336, 371);
            resultsTextBox.TabIndex = 0;
            // 
            // inputBox
            // 
            inputBox.Controls.Add(stopValueText);
            inputBox.Controls.Add(stopValue);
            inputBox.Controls.Add(startValue);
            inputBox.Controls.Add(startValueText);
            inputBox.Location = new Point(12, 349);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(282, 89);
            inputBox.TabIndex = 2;
            inputBox.TabStop = false;
            inputBox.Text = "Ввод данных";
            // 
            // stopValueText
            // 
            stopValueText.AutoSize = true;
            stopValueText.Location = new Point(149, 25);
            stopValueText.Name = "stopValueText";
            stopValueText.Size = new Size(94, 20);
            stopValueText.TabIndex = 3;
            stopValueText.Text = "Конец шага:";
            // 
            // stopValue
            // 
            stopValue.Location = new Point(149, 52);
            stopValue.Name = "stopValue";
            stopValue.Size = new Size(116, 27);
            stopValue.TabIndex = 2;
            // 
            // startValue
            // 
            startValue.Location = new Point(6, 52);
            startValue.Name = "startValue";
            startValue.Size = new Size(116, 27);
            startValue.TabIndex = 1;
            // 
            // startValueText
            // 
            startValueText.AutoSize = true;
            startValueText.Location = new Point(6, 25);
            startValueText.Name = "startValueText";
            startValueText.Size = new Size(88, 20);
            startValueText.TabIndex = 0;
            startValueText.Text = "Старт шага:";
            // 
            // completeButton
            // 
            completeButton.BackColor = Color.LimeGreen;
            completeButton.Font = new Font("Segoe UI", 8F);
            completeButton.Location = new Point(460, 362);
            completeButton.Name = "completeButton";
            completeButton.Size = new Size(105, 76);
            completeButton.TabIndex = 4;
            completeButton.Text = "Выполнить";
            completeButton.UseVisualStyleBackColor = false;
            completeButton.Click += completeButton_Click;
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.FromArgb(128, 128, 255);
            infoButton.Location = new Point(328, 362);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(105, 76);
            infoButton.TabIndex = 5;
            infoButton.Text = "Сведения";
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 450);
            Controls.Add(infoButton);
            Controls.Add(completeButton);
            Controls.Add(inputBox);
            Controls.Add(outputBox);
            Controls.Add(conditionBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Sprint 6 | Task 1 | V14 | Safronove V.E.";
            Load += Form1_Load;
            conditionBox.ResumeLayout(false);
            conditionBox.PerformLayout();
            outputBox.ResumeLayout(false);
            outputBox.PerformLayout();
            inputBox.ResumeLayout(false);
            inputBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox conditionBox;
        private Label conditionText;
        private Label conditionText2;
        private GroupBox outputBox;
        private Label outputText;
        private TextBox resultsTextBox;
        private GroupBox inputBox;
        private Label startValueText;
        private Button completeButton;
        private Label stopValueText;
        private TextBox stopValue;
        private TextBox startValue;
        private Button infoButton;
    }
}
