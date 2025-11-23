namespace Tyuiu.SafronovVE.Sprint6.Task7.V28
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
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            panelCondition = new Panel();
            groupBoxCondition = new GroupBox();
            splitContainerMain = new SplitContainer();
            groupBoxInput = new GroupBox();
            dataGridViewIn = new DataGridView();
            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();
            openFileDialog = new OpenFileDialog();
            toolTip = new ToolTip(components);
            saveFileDialog = new SaveFileDialog();
            label1 = new Label();
            panelTop.SuspendLayout();
            panelCondition.SuspendLayout();
            groupBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonAbout);
            panelTop.Controls.Add(buttonSaveFile);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1133, 89);
            panelTop.TabIndex = 0;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = SystemColors.Control;
            buttonAbout.BackgroundImage = Properties.Resources.Help;
            buttonAbout.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAbout.Dock = DockStyle.Right;
            buttonAbout.Location = new Point(1032, 0);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(101, 89);
            buttonAbout.TabIndex = 3;
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.BackgroundImage = Properties.Resources.Printer;
            buttonSaveFile.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveFile.Dock = DockStyle.Left;
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Location = new Point(202, 0);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(101, 89);
            buttonSaveFile.TabIndex = 2;
            buttonSaveFile.UseVisualStyleBackColor = true;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackgroundImage = Properties.Resources.Folder_Search;
            buttonDone.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDone.Dock = DockStyle.Left;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Location = new Point(101, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(101, 89);
            buttonDone.TabIndex = 1;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackgroundImage = Properties.Resources.Folder1;
            buttonOpenFile.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile.Dock = DockStyle.Left;
            buttonOpenFile.FlatStyle = FlatStyle.Flat;
            buttonOpenFile.Location = new Point(0, 0);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(101, 89);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // panelCondition
            // 
            panelCondition.Controls.Add(groupBoxCondition);
            panelCondition.Dock = DockStyle.Top;
            panelCondition.Location = new Point(0, 89);
            panelCondition.Name = "panelCondition";
            panelCondition.Size = new Size(1133, 125);
            panelCondition.TabIndex = 1;
            // 
            // groupBoxCondition
            // 
            groupBoxCondition.Controls.Add(label1);
            groupBoxCondition.Dock = DockStyle.Fill;
            groupBoxCondition.Location = new Point(0, 0);
            groupBoxCondition.Name = "groupBoxCondition";
            groupBoxCondition.Size = new Size(1133, 125);
            groupBoxCondition.TabIndex = 0;
            groupBoxCondition.TabStop = false;
            groupBoxCondition.Text = "Условие:";
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 214);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.Controls.Add(groupBoxInput);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(groupBoxOut);
            splitContainerMain.Size = new Size(1133, 440);
            splitContainerMain.SplitterDistance = 569;
            splitContainerMain.TabIndex = 2;
            // 
            // groupBoxInput
            // 
            groupBoxInput.Controls.Add(dataGridViewIn);
            groupBoxInput.Dock = DockStyle.Fill;
            groupBoxInput.Location = new Point(0, 0);
            groupBoxInput.Name = "groupBoxInput";
            groupBoxInput.Size = new Size(569, 440);
            groupBoxInput.TabIndex = 0;
            groupBoxInput.TabStop = false;
            groupBoxInput.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 23);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.RowHeadersVisible = false;
            dataGridViewIn.RowHeadersWidth = 51;
            dataGridViewIn.Size = new Size(563, 414);
            dataGridViewIn.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridViewOut);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(560, 440);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 23);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.RowHeadersVisible = false;
            dataGridViewOut.RowHeadersWidth = 51;
            dataGridViewOut.Size = new Size(554, 414);
            dataGridViewOut.TabIndex = 0;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 23);
            label1.Name = "label1";
            label1.Size = new Size(1127, 99);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 654);
            Controls.Add(splitContainerMain);
            Controls.Add(panelCondition);
            Controls.Add(panelTop);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sprint 6 | Task 7 | V28 | Safronov V. E.";
            WindowState = FormWindowState.Maximized;
            panelTop.ResumeLayout(false);
            panelCondition.ResumeLayout(false);
            groupBoxCondition.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelCondition;
        private SplitContainer splitContainerMain;
        private GroupBox groupBoxInput;
        private GroupBox groupBoxOut;
        private GroupBox groupBoxCondition;
        private Button buttonOpenFile;
        private Button buttonAbout;
        private Button buttonSaveFile;
        private Button buttonDone;
        private DataGridView dataGridViewIn;
        private DataGridView dataGridViewOut;
        private OpenFileDialog openFileDialog;
        private ToolTip toolTip;
        private SaveFileDialog saveFileDialog;
        private Label label1;
    }
}
