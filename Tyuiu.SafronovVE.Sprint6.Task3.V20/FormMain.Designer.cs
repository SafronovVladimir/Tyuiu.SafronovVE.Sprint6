namespace Tyuiu.SafronovVE.Sprint6.Task3.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SVE));
            groupBoxTask_SVE = new GroupBox();
            dataGridViewMatrix_SVE = new DataGridView();
            textBoxTask_SVE = new TextBox();
            groupBoxOutput_SVE = new GroupBox();
            dataGridViewResult_SVE = new DataGridView();
            buttonHelp_SVE = new Button();
            buttonDone_SVE = new Button();
            groupBoxTask_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SVE).BeginInit();
            groupBoxOutput_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SVE).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(dataGridViewMatrix_SVE);
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Location = new Point(12, 12);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(559, 349);
            groupBoxTask_SVE.TabIndex = 0;
            groupBoxTask_SVE.TabStop = false;
            groupBoxTask_SVE.Text = "Условие";
            // 
            // dataGridViewMatrix_SVE
            // 
            dataGridViewMatrix_SVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_SVE.ColumnHeadersVisible = false;
            dataGridViewMatrix_SVE.Location = new Point(257, 26);
            dataGridViewMatrix_SVE.Name = "dataGridViewMatrix_SVE";
            dataGridViewMatrix_SVE.ReadOnly = true;
            dataGridViewMatrix_SVE.RowHeadersVisible = false;
            dataGridViewMatrix_SVE.RowHeadersWidth = 51;
            dataGridViewMatrix_SVE.Size = new Size(296, 303);
            dataGridViewMatrix_SVE.TabIndex = 1;
            // 
            // textBoxTask_SVE
            // 
            textBoxTask_SVE.BorderStyle = BorderStyle.None;
            textBoxTask_SVE.Location = new Point(6, 26);
            textBoxTask_SVE.Multiline = true;
            textBoxTask_SVE.Name = "textBoxTask_SVE";
            textBoxTask_SVE.ReadOnly = true;
            textBoxTask_SVE.Size = new Size(226, 303);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = resources.GetString("textBoxTask_SVE.Text");
            // 
            // groupBoxOutput_SVE
            // 
            groupBoxOutput_SVE.Controls.Add(dataGridViewResult_SVE);
            groupBoxOutput_SVE.Location = new Point(577, 12);
            groupBoxOutput_SVE.Name = "groupBoxOutput_SVE";
            groupBoxOutput_SVE.Size = new Size(308, 349);
            groupBoxOutput_SVE.TabIndex = 1;
            groupBoxOutput_SVE.TabStop = false;
            groupBoxOutput_SVE.Text = "Вывод данных";
            // 
            // dataGridViewResult_SVE
            // 
            dataGridViewResult_SVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SVE.ColumnHeadersVisible = false;
            dataGridViewResult_SVE.Location = new Point(6, 26);
            dataGridViewResult_SVE.Name = "dataGridViewResult_SVE";
            dataGridViewResult_SVE.ReadOnly = true;
            dataGridViewResult_SVE.RowHeadersVisible = false;
            dataGridViewResult_SVE.RowHeadersWidth = 51;
            dataGridViewResult_SVE.Size = new Size(296, 303);
            dataGridViewResult_SVE.TabIndex = 2;
            // 
            // buttonHelp_SVE
            // 
            buttonHelp_SVE.Location = new Point(712, 366);
            buttonHelp_SVE.Name = "buttonHelp_SVE";
            buttonHelp_SVE.Size = new Size(42, 36);
            buttonHelp_SVE.TabIndex = 2;
            buttonHelp_SVE.Text = "?";
            buttonHelp_SVE.UseVisualStyleBackColor = true;
            buttonHelp_SVE.Click += buttonHelp_SVE_Click;
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.Location = new Point(760, 366);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(125, 36);
            buttonDone_SVE.TabIndex = 3;
            buttonDone_SVE.Text = "Выполнить";
            buttonDone_SVE.UseVisualStyleBackColor = true;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 408);
            Controls.Add(buttonDone_SVE);
            Controls.Add(buttonHelp_SVE);
            Controls.Add(groupBoxOutput_SVE);
            Controls.Add(groupBoxTask_SVE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain_SVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Сафронов В. Е.";
            Load += FormMain_SVE_Load;
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_SVE).EndInit();
            groupBoxOutput_SVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SVE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_SVE;
        private TextBox textBoxTask_SVE;
        private DataGridView dataGridViewMatrix_SVE;
        private GroupBox groupBoxOutput_SVE;
        private Button buttonHelp_SVE;
        private Button buttonDone_SVE;
        private DataGridView dataGridViewResult_SVE;
    }
}
