namespace Tyuiu.SafronovVE.Sprint6.Task3.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            textBoxTask = new TextBox();
            groupBoxOutput = new GroupBox();
            dataGridViewResult = new DataGridView();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(dataGridViewMatrix);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(525, 349);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(238, 26);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.ReadOnly = true;
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(281, 303);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(235, 303);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxOutput
            // 
            groupBoxOutput.Controls.Add(dataGridViewResult);
            groupBoxOutput.Location = new Point(543, 12);
            groupBoxOutput.Name = "groupBoxOutput";
            groupBoxOutput.Size = new Size(293, 349);
            groupBoxOutput.TabIndex = 1;
            groupBoxOutput.TabStop = false;
            groupBoxOutput.Text = "Вывод данных";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.ColumnHeadersVisible = false;
            dataGridViewResult.Location = new Point(6, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(281, 303);
            dataGridViewResult.TabIndex = 2;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(663, 367);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(42, 36);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(711, 367);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(125, 36);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 414);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxOutput);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 20 | Сафронов В. Е.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxOutput;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewResult;
    }
}
