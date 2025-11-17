namespace Tyuiu.SafronovVE.Sprint6.Task3.V20
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
            conditionGroupBox = new GroupBox();
            conditionLabel = new Label();
            outputGroupBox = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            doneButton = new Button();
            button1 = new Button();
            conditionGroupBox.SuspendLayout();
            outputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // conditionGroupBox
            // 
            conditionGroupBox.Controls.Add(conditionLabel);
            conditionGroupBox.Location = new Point(12, 12);
            conditionGroupBox.Name = "conditionGroupBox";
            conditionGroupBox.Size = new Size(330, 426);
            conditionGroupBox.TabIndex = 0;
            conditionGroupBox.TabStop = false;
            conditionGroupBox.Text = "Условие";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(6, 23);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(200, 200);
            conditionLabel.TabIndex = 0;
            conditionLabel.Text = "Дана матрица 5 на 5\r\n\r\n-14  17 -19   3   2\r\n -4 -14 -19  -9  -1\r\n   1    0   13  14   8\r\n  13   7    8   -3 -15\r\n   2  -20  12 -14  4\r\n\r\nЗаменить четные значения\r\nв пятой строке на 0.\r\n";
            // 
            // outputGroupBox
            // 
            outputGroupBox.Controls.Add(dataGridViewMatrix);
            outputGroupBox.Location = new Point(348, 12);
            outputGroupBox.Name = "outputGroupBox";
            outputGroupBox.Size = new Size(310, 331);
            outputGroupBox.TabIndex = 1;
            outputGroupBox.TabStop = false;
            outputGroupBox.Text = "Вывод";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.ColumnHeadersVisible = false;
            dataGridViewMatrix.Location = new Point(6, 26);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(288, 188);
            dataGridViewMatrix.TabIndex = 0;
            dataGridViewMatrix.CellContentClick += dataGridView1_CellContentClick;
            // 
            // doneButton
            // 
            doneButton.Location = new Point(529, 367);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(113, 71);
            doneButton.TabIndex = 2;
            doneButton.Text = "Выполнить";
            doneButton.UseVisualStyleBackColor = true;
            doneButton.Click += doneButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(367, 367);
            button1.Name = "button1";
            button1.Size = new Size(113, 71);
            button1.TabIndex = 3;
            button1.Text = "Сведения";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 450);
            Controls.Add(button1);
            Controls.Add(doneButton);
            Controls.Add(outputGroupBox);
            Controls.Add(conditionGroupBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 3 | V20 | Safronov V.E.";
            Load += Form1_Load;
            conditionGroupBox.ResumeLayout(false);
            conditionGroupBox.PerformLayout();
            outputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox conditionGroupBox;
        private Label conditionLabel;
        private GroupBox outputGroupBox;
        private DataGridView dataGridViewMatrix;
        private Button doneButton;
        private Button button1;
    }
}
