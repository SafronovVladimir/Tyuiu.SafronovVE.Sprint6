namespace Tyuiu.SafronovVE.Sprint6.Task0.V24
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
            pictureBoxFormula_SVE = new PictureBox();
            textBoxTask_SVE = new TextBox();
            groupBoxInput_SVE = new GroupBox();
            textBoxVarX_SVE = new TextBox();
            labelVarX_SVE = new Label();
            groupBoxOutput_SVE = new GroupBox();
            textBoxResult_SVE = new TextBox();
            labelResult_SVE = new Label();
            buttonDone_SVE = new Button();
            buttonHelp_SVE = new Button();
            groupBoxTask_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SVE).BeginInit();
            groupBoxInput_SVE.SuspendLayout();
            groupBoxOutput_SVE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(pictureBoxFormula_SVE);
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Location = new Point(12, 12);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(776, 231);
            groupBoxTask_SVE.TabIndex = 0;
            groupBoxTask_SVE.TabStop = false;
            groupBoxTask_SVE.Text = "Условие";
            // 
            // pictureBoxFormula_SVE
            // 
            pictureBoxFormula_SVE.Image = Properties.Resources.unnamed;
            pictureBoxFormula_SVE.Location = new Point(568, 26);
            pictureBoxFormula_SVE.Name = "pictureBoxFormula_SVE";
            pictureBoxFormula_SVE.Size = new Size(202, 82);
            pictureBoxFormula_SVE.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_SVE.TabIndex = 1;
            pictureBoxFormula_SVE.TabStop = false;
            // 
            // textBoxTask_SVE
            // 
            textBoxTask_SVE.BackColor = SystemColors.Control;
            textBoxTask_SVE.BorderStyle = BorderStyle.None;
            textBoxTask_SVE.Location = new Point(6, 26);
            textBoxTask_SVE.Multiline = true;
            textBoxTask_SVE.Name = "textBoxTask_SVE";
            textBoxTask_SVE.Size = new Size(556, 191);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = "Вычислить выражение по формуле\r\n";
            // 
            // groupBoxInput_SVE
            // 
            groupBoxInput_SVE.Controls.Add(textBoxVarX_SVE);
            groupBoxInput_SVE.Controls.Add(labelVarX_SVE);
            groupBoxInput_SVE.Location = new Point(12, 249);
            groupBoxInput_SVE.Name = "groupBoxInput_SVE";
            groupBoxInput_SVE.Size = new Size(524, 110);
            groupBoxInput_SVE.TabIndex = 1;
            groupBoxInput_SVE.TabStop = false;
            groupBoxInput_SVE.Text = "Ввод данных";
            // 
            // textBoxVarX_SVE
            // 
            textBoxVarX_SVE.BackColor = SystemColors.Window;
            textBoxVarX_SVE.Location = new Point(15, 56);
            textBoxVarX_SVE.Name = "textBoxVarX_SVE";
            textBoxVarX_SVE.Size = new Size(114, 27);
            textBoxVarX_SVE.TabIndex = 1;
            textBoxVarX_SVE.KeyPress += textBoxVarX_SVE_KeyPress;
            // 
            // labelVarX_SVE
            // 
            labelVarX_SVE.AutoSize = true;
            labelVarX_SVE.Location = new Point(15, 33);
            labelVarX_SVE.Name = "labelVarX_SVE";
            labelVarX_SVE.Size = new Size(114, 20);
            labelVarX_SVE.TabIndex = 0;
            labelVarX_SVE.Text = "Переменная X:";
            // 
            // groupBoxOutput_SVE
            // 
            groupBoxOutput_SVE.Controls.Add(textBoxResult_SVE);
            groupBoxOutput_SVE.Controls.Add(labelResult_SVE);
            groupBoxOutput_SVE.Location = new Point(542, 249);
            groupBoxOutput_SVE.Name = "groupBoxOutput_SVE";
            groupBoxOutput_SVE.Size = new Size(246, 110);
            groupBoxOutput_SVE.TabIndex = 2;
            groupBoxOutput_SVE.TabStop = false;
            groupBoxOutput_SVE.Text = "Вывод данных";
            // 
            // textBoxResult_SVE
            // 
            textBoxResult_SVE.Location = new Point(15, 56);
            textBoxResult_SVE.Name = "textBoxResult_SVE";
            textBoxResult_SVE.ReadOnly = true;
            textBoxResult_SVE.Size = new Size(225, 27);
            textBoxResult_SVE.TabIndex = 1;
            // 
            // labelResult_SVE
            // 
            labelResult_SVE.AutoSize = true;
            labelResult_SVE.Location = new Point(15, 33);
            labelResult_SVE.Name = "labelResult_SVE";
            labelResult_SVE.Size = new Size(78, 20);
            labelResult_SVE.TabIndex = 0;
            labelResult_SVE.Text = "Результат:";
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.Location = new Point(601, 365);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(187, 46);
            buttonDone_SVE.TabIndex = 3;
            buttonDone_SVE.Text = "Выполнить";
            buttonDone_SVE.UseVisualStyleBackColor = true;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            // 
            // buttonHelp_SVE
            // 
            buttonHelp_SVE.FlatStyle = FlatStyle.Flat;
            buttonHelp_SVE.Location = new Point(542, 365);
            buttonHelp_SVE.Name = "buttonHelp_SVE";
            buttonHelp_SVE.Size = new Size(53, 46);
            buttonHelp_SVE.TabIndex = 4;
            buttonHelp_SVE.Text = "?";
            buttonHelp_SVE.UseVisualStyleBackColor = true;
            buttonHelp_SVE.Click += buttonHelp_SVE_Click;
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 425);
            Controls.Add(buttonHelp_SVE);
            Controls.Add(buttonDone_SVE);
            Controls.Add(groupBoxOutput_SVE);
            Controls.Add(groupBoxInput_SVE);
            Controls.Add(groupBoxTask_SVE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_SVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 24 | Сафронов В.Е.";
            Load += FormMain_Load;
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SVE).EndInit();
            groupBoxInput_SVE.ResumeLayout(false);
            groupBoxInput_SVE.PerformLayout();
            groupBoxOutput_SVE.ResumeLayout(false);
            groupBoxOutput_SVE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SVE;
        private TextBox textBoxTask_SVE;
        private PictureBox pictureBoxFormula_SVE;
        private GroupBox groupBoxInput_SVE;
        private TextBox textBoxVarX_SVE;
        private Label labelVarX_SVE;
        private GroupBox groupBoxOutput_SVE;
        private TextBox textBoxResult_SVE;
        private Label labelResult_SVE;
        private Button buttonDone_SVE;
        private Button buttonHelp_SVE;
    }
}
