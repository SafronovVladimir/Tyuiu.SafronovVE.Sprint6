namespace Tyuiu.SafronovVE.Sprint6.Task0.V24
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
            pictureBoxFormula = new PictureBox();
            textBoxTask = new TextBox();
            groupBoxInput = new GroupBox();
            textBoxVarX = new TextBox();
            labelVarX = new Label();
            groupBoxOutput = new GroupBox();
            textBoxResult = new TextBox();
            labelResult = new Label();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxInput.SuspendLayout();
            groupBoxOutput.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(776, 231);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.unnamed;
            pictureBoxFormula.Location = new Point(568, 26);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(202, 82);
            pictureBoxFormula.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(556, 191);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле\r\n";
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(textBoxVarX);
            groupBoxInput.Controls.Add(labelVarX);
            groupBoxInput.Location = new Point(12, 249);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(524, 110);
            groupBoxInput.TabIndex = 1;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.BackColor = SystemColors.Window;
            textBoxVarX.Location = new Point(15, 56);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(114, 27);
            textBoxVarX.TabIndex = 1;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // labelVarX
            // 
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(15, 33);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(114, 20);
            labelVarX.TabIndex = 0;
            labelVarX.Text = "Переменная X:";
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(textBoxResult);
            groupBoxOutput.Controls.Add(labelResult);
            groupBoxOutput.Location = new Point(542, 249);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(246, 110);
            groupBoxOutput.TabIndex = 2;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(15, 56);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(225, 27);
            textBoxResult.TabIndex = 1;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(15, 33);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(78, 20);
            labelResult.TabIndex = 0;
            labelResult.Text = "Результат:";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(601, 365);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(187, 46);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(542, 365);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(53, 46);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxInput);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 24 | Сафронов В.Е.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxInput.ResumeLayout(false);
            groupBoxInput.PerformLayout();
            groupBoxOutput.ResumeLayout(false);
            groupBoxOutput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxInput;
        private TextBox textBoxVarX;
        private Label labelVarX;
        private GroupBox groupBoxOutput;
        private TextBox textBoxResult;
        private Label labelResult;
        private Button buttonDone;
        private Button buttonHelp;
    }
}
