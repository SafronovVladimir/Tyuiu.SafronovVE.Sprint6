namespace Tyuiu.SafronovVE.Sprint6.Task6.V16
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop = new Panel();
            buttonAbout = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panelCondition = new Panel();
            textBoxCondition = new TextBox();
            labelCondition = new Label();
            textBoxInput = new TextBox();
            textBoxOut = new TextBox();
            toolTip1 = new ToolTip(components);
            openFileDialog = new OpenFileDialog();
            labelOutput = new Label();
            inputLabel = new Label();
            panelTop.SuspendLayout();
            panelCondition.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BorderStyle = BorderStyle.FixedSingle;
            panelTop.Controls.Add(buttonAbout);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1048, 95);
            panelTop.TabIndex = 0;
            // 
            // buttonAbout
            // 
            buttonAbout.BackgroundImage = Properties.Resources.User;
            buttonAbout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout.Dock = DockStyle.Right;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Location = new Point(940, 0);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(106, 93);
            buttonAbout.TabIndex = 2;
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click_1;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImage = Properties.Resources.Link;
            buttonDone.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDone.Dock = DockStyle.Left;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Location = new Point(106, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(106, 93);
            buttonDone.TabIndex = 1;
            toolTip1.SetToolTip(buttonDone, "Производит поиск в файле вхождений символов \"b\"\r\nи конкатенирует строки в которых находятся\r\nэти символов");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackgroundImage = Properties.Resources.Folder;
            buttonOpenFile.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOpenFile.Dock = DockStyle.Left;
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Location = new Point(0, 0);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(106, 93);
            buttonOpenFile.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panelCondition
            // 
            panelCondition.Controls.Add(textBoxCondition);
            panelCondition.Controls.Add(labelCondition);
            panelCondition.Dock = DockStyle.Top;
            panelCondition.Location = new Point(0, 95);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(1048, 125);
            panelCondition.TabIndex = 2;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCondition.BackColor = SystemColors.Control;
            textBoxCondition.BorderStyle = BorderStyle.None;
            textBoxCondition.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCondition.Location = new Point(12, 26);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(1024, 96);
            textBoxCondition.TabIndex = 1;
            textBoxCondition.Text = resources.GetString("textBoxCondition.Text");
            // 
            // labelCondition
            // 
            labelCondition.AutoSize = true;
            labelCondition.Location = new Point(12, 3);
            labelCondition.Name = "labelCondition";
            labelCondition.Size = new Size(70, 20);
            labelCondition.TabIndex = 0;
            labelCondition.Text = "Условие:";
            // 
            // textBoxInput
            // 
            textBoxInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxInput.BackColor = SystemColors.Window;
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Location = new Point(12, 246);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.ScrollBars = ScrollBars.Vertical;
            textBoxInput.Size = new Size(489, 336);
            textBoxInput.TabIndex = 6;
            // 
            // textBoxOut
            // 
            textBoxOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxOut.BackColor = SystemColors.Window;
            textBoxOut.BorderStyle = BorderStyle.None;
            textBoxOut.Location = new Point(547, 246);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(489, 336);
            textBoxOut.TabIndex = 7;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog2";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(547, 223);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(57, 20);
            labelOutput.TabIndex = 4;
            labelOutput.Text = "Вывод:";
            // 
            // inputLabel
            // 
            inputLabel.AutoSize = true;
            inputLabel.Location = new Point(12, 223);
            inputLabel.Name = "inputLabel";
            inputLabel.Size = new Size(46, 20);
            inputLabel.TabIndex = 3;
            inputLabel.Text = "Ввод:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 594);
            Controls.Add(textBoxOut);
            Controls.Add(textBoxInput);
            Controls.Add(labelOutput);
            Controls.Add(inputLabel);
            Controls.Add(panelCondition);
            Controls.Add(panelTop);
            Name = "FormMain";
            Text = "Sprint 6 | Task 6 | V16 | Safronov V. E.";
            panelTop.ResumeLayout(false);
            panelCondition.ResumeLayout(false);
            panelCondition.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private Button buttonAbout;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Panel panelCondition;
        private Label labelCondition;
        private TextBox textBoxCondition;
        private TextBox textBoxInput;
        private TextBox textBoxOut;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog;
        private Label labelOutput;
        private Label inputLabel;
    }
}
