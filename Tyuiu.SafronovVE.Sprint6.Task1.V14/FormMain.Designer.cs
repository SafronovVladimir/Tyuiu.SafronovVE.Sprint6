namespace Tyuiu.SafronovVE.Sprint6.Task1.V14
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxOut = new GroupBox();
            textBoxResult = new TextBox();
            labelResult = new Label();
            groupBoxIn = new GroupBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            labelStopStep = new Label();
            labelStartStep = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            groupBoxOut.SuspendLayout();
            groupBoxIn.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(594, 335);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(6, 31);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(582, 298);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxResult);
            groupBoxOut.Controls.Add(labelResult);
            groupBoxOut.Location = new Point(612, 12);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(410, 426);
            groupBoxOut.TabIndex = 1;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Control;
            textBoxResult.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 46);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(398, 368);
            textBoxResult.TabIndex = 1;
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
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxStopStep);
            groupBoxIn.Controls.Add(textBoxStartStep);
            groupBoxIn.Controls.Add(labelStopStep);
            groupBoxIn.Controls.Add(labelStartStep);
            groupBoxIn.Location = new Point(12, 353);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(331, 85);
            groupBoxIn.TabIndex = 2;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод данных";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(167, 46);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(148, 27);
            textBoxStopStep.TabIndex = 3;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 46);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(148, 27);
            textBoxStartStep.TabIndex = 2;
            // 
            // labelStopStep
            // 
            labelStopStep.AutoSize = true;
            labelStopStep.Location = new Point(167, 23);
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
            buttonHelp.BackColor = SystemColors.HotTrack;
            buttonHelp.Location = new Point(349, 362);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(107, 76);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(462, 362);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(144, 76);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxIn);
            Controls.Add(groupBoxOut);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Сафронов В.Е.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxOut;
        private GroupBox groupBoxIn;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private Label labelStopStep;
        private Label labelStartStep;
        private TextBox textBoxTask;
        private Label labelResult;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxResult;
    }
}
