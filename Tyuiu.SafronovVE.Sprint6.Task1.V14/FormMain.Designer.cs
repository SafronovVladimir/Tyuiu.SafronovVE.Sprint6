namespace Tyuiu.SafronovVE.Sprint6.Task1.V14
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
            groupBoxTask_SVE = new GroupBox();
            textBoxTask_SVE = new TextBox();
            groupBoxOut_SVE = new GroupBox();
            textBoxResult_SVE = new TextBox();
            labelResult_SVE = new Label();
            groupBoxIn_SVE = new GroupBox();
            textBoxStopStep_SVE = new TextBox();
            textBoxStartStep_SVE = new TextBox();
            labelStopStep_SVE = new Label();
            labelStartStep_SVE = new Label();
            buttonHelp_SVE = new Button();
            buttonDone_SVE = new Button();
            groupBoxTask_SVE.SuspendLayout();
            groupBoxOut_SVE.SuspendLayout();
            groupBoxIn_SVE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Location = new Point(12, 12);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(594, 335);
            groupBoxTask_SVE.TabIndex = 0;
            groupBoxTask_SVE.TabStop = false;
            groupBoxTask_SVE.Text = "Условие";
            // 
            // textBoxTask_SVE
            // 
            textBoxTask_SVE.BackColor = SystemColors.Control;
            textBoxTask_SVE.BorderStyle = BorderStyle.None;
            textBoxTask_SVE.Location = new Point(6, 31);
            textBoxTask_SVE.Multiline = true;
            textBoxTask_SVE.Name = "textBoxTask_SVE";
            textBoxTask_SVE.Size = new Size(582, 298);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxOut_SVE
            // 
            groupBoxOut_SVE.Controls.Add(textBoxResult_SVE);
            groupBoxOut_SVE.Controls.Add(labelResult_SVE);
            groupBoxOut_SVE.Location = new Point(612, 12);
            groupBoxOut_SVE.Name = "groupBoxOut_SVE";
            groupBoxOut_SVE.Size = new Size(410, 426);
            groupBoxOut_SVE.TabIndex = 1;
            groupBoxOut_SVE.TabStop = false;
            groupBoxOut_SVE.Text = "Вывод данных";
            // 
            // textBoxResult_SVE
            // 
            textBoxResult_SVE.BackColor = SystemColors.Control;
            textBoxResult_SVE.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_SVE.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_SVE.Location = new Point(6, 46);
            textBoxResult_SVE.Multiline = true;
            textBoxResult_SVE.Name = "textBoxResult_SVE";
            textBoxResult_SVE.ReadOnly = true;
            textBoxResult_SVE.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SVE.Size = new Size(398, 368);
            textBoxResult_SVE.TabIndex = 1;
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
            // groupBoxIn_SVE
            // 
            groupBoxIn_SVE.Controls.Add(textBoxStopStep_SVE);
            groupBoxIn_SVE.Controls.Add(textBoxStartStep_SVE);
            groupBoxIn_SVE.Controls.Add(labelStopStep_SVE);
            groupBoxIn_SVE.Controls.Add(labelStartStep_SVE);
            groupBoxIn_SVE.Location = new Point(12, 353);
            groupBoxIn_SVE.Name = "groupBoxIn_SVE";
            groupBoxIn_SVE.Size = new Size(331, 85);
            groupBoxIn_SVE.TabIndex = 2;
            groupBoxIn_SVE.TabStop = false;
            groupBoxIn_SVE.Text = "Ввод данных";
            // 
            // textBoxStopStep_SVE
            // 
            textBoxStopStep_SVE.Location = new Point(167, 46);
            textBoxStopStep_SVE.Name = "textBoxStopStep_SVE";
            textBoxStopStep_SVE.Size = new Size(148, 27);
            textBoxStopStep_SVE.TabIndex = 3;
            // 
            // textBoxStartStep_SVE
            // 
            textBoxStartStep_SVE.Location = new Point(6, 46);
            textBoxStartStep_SVE.Name = "textBoxStartStep_SVE";
            textBoxStartStep_SVE.Size = new Size(148, 27);
            textBoxStartStep_SVE.TabIndex = 2;
            // 
            // labelStopStep_SVE
            // 
            labelStopStep_SVE.AutoSize = true;
            labelStopStep_SVE.Location = new Point(167, 23);
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
            buttonHelp_SVE.BackColor = SystemColors.HotTrack;
            buttonHelp_SVE.Location = new Point(349, 362);
            buttonHelp_SVE.Name = "buttonHelp_SVE";
            buttonHelp_SVE.Size = new Size(107, 76);
            buttonHelp_SVE.TabIndex = 3;
            buttonHelp_SVE.Text = "Справка";
            buttonHelp_SVE.UseVisualStyleBackColor = false;
            buttonHelp_SVE.Click += buttonHelp_SVE_Click;
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.BackColor = Color.Green;
            buttonDone_SVE.Location = new Point(462, 362);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(144, 76);
            buttonDone_SVE.TabIndex = 4;
            buttonDone_SVE.Text = "Выполнить";
            buttonDone_SVE.UseVisualStyleBackColor = false;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 450);
            Controls.Add(buttonDone_SVE);
            Controls.Add(buttonHelp_SVE);
            Controls.Add(groupBoxIn_SVE);
            Controls.Add(groupBoxOut_SVE);
            Controls.Add(groupBoxTask_SVE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_SVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 14 | Сафронов В. Е.";
            Load += FormMain_SVE_Load;
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            groupBoxOut_SVE.ResumeLayout(false);
            groupBoxOut_SVE.PerformLayout();
            groupBoxIn_SVE.ResumeLayout(false);
            groupBoxIn_SVE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SVE;
        private GroupBox groupBoxOut_SVE;
        private GroupBox groupBoxIn_SVE;
        private TextBox textBoxStopStep_SVE;
        private TextBox textBoxStartStep_SVE;
        private Label labelStopStep_SVE;
        private Label labelStartStep_SVE;
        private TextBox textBoxTask_SVE;
        private Label labelResult_SVE;
        private Button buttonHelp_SVE;
        private Button buttonDone_SVE;
        private TextBox textBoxResult_SVE;
    }
}
