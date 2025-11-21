namespace Tyuiu.SafronovVE.Sprint6.Task5.V19
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
            conditionTextBox = new TextBox();
            topPanel = new Panel();
            infoButton = new Button();
            openFileButton = new Button();
            doneButton = new Button();
            conditionGroupBox = new GroupBox();
            inputGroupBox = new GroupBox();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            topPanel.SuspendLayout();
            conditionGroupBox.SuspendLayout();
            inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // conditionTextBox
            // 
            conditionTextBox.BackColor = SystemColors.Control;
            conditionTextBox.BorderStyle = BorderStyle.None;
            conditionTextBox.Location = new Point(7, 23);
            conditionTextBox.Multiline = true;
            conditionTextBox.Name = "conditionTextBox";
            conditionTextBox.ReadOnly = true;
            conditionTextBox.Size = new Size(494, 43);
            conditionTextBox.TabIndex = 0;
            conditionTextBox.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\nцелые значения и построить диаграмму по этим значениям.\r\n";
            // 
            // topPanel
            // 
            topPanel.BorderStyle = BorderStyle.FixedSingle;
            topPanel.Controls.Add(infoButton);
            topPanel.Controls.Add(openFileButton);
            topPanel.Controls.Add(doneButton);
            topPanel.Controls.Add(conditionGroupBox);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(865, 95);
            topPanel.TabIndex = 0;
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.RoyalBlue;
            infoButton.Location = new Point(752, 11);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(107, 70);
            infoButton.TabIndex = 3;
            infoButton.Text = "Справка";
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // openFileButton
            // 
            openFileButton.BackColor = SystemColors.HotTrack;
            openFileButton.Location = new Point(639, 11);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(107, 70);
            openFileButton.TabIndex = 2;
            openFileButton.Text = "Открыть файл";
            openFileButton.UseVisualStyleBackColor = false;
            openFileButton.Click += openFileButton_Click;
            // 
            // doneButton
            // 
            doneButton.BackColor = Color.FromArgb(0, 192, 0);
            doneButton.Location = new Point(526, 11);
            doneButton.Name = "doneButton";
            doneButton.Size = new Size(107, 70);
            doneButton.TabIndex = 1;
            doneButton.Text = "Выполнить";
            doneButton.UseVisualStyleBackColor = false;
            doneButton.Click += doneButton_Click;
            // 
            // conditionGroupBox
            // 
            conditionGroupBox.Controls.Add(conditionTextBox);
            conditionGroupBox.Location = new Point(8, 3);
            conditionGroupBox.Name = "conditionGroupBox";
            conditionGroupBox.Size = new Size(502, 78);
            conditionGroupBox.TabIndex = 0;
            conditionGroupBox.TabStop = false;
            conditionGroupBox.Text = "Условие:";
            // 
            // inputGroupBox
            // 
            inputGroupBox.Controls.Add(dataGridView);
            inputGroupBox.Location = new Point(9, 101);
            inputGroupBox.Name = "inputGroupBox";
            inputGroupBox.Size = new Size(184, 470);
            inputGroupBox.TabIndex = 1;
            inputGroupBox.TabStop = false;
            inputGroupBox.Text = "Вывод данных:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView.Location = new Point(0, 26);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(178, 444);
            dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 75;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(199, 96);
            chartDiag.Name = "chartDiag";
            chartDiag.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(666, 478);
            chartDiag.TabIndex = 2;
            chartDiag.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 574);
            Controls.Add(chartDiag);
            Controls.Add(inputGroupBox);
            Controls.Add(topPanel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 5 | V19 | Safronov V. E.";
            topPanel.ResumeLayout(false);
            conditionGroupBox.ResumeLayout(false);
            conditionGroupBox.PerformLayout();
            inputGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private GroupBox conditionGroupBox;
        private TextBox conditionTextBox;
        private Button doneButton;
        private Button openFileButton;
        private Button infoButton;
        private GroupBox inputGroupBox;
        private DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
