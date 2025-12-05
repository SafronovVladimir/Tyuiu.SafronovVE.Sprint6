namespace Tyuiu.SafronovVE.Sprint6.Task6.V16
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_SVE));
            panelTop_SVE = new Panel();
            buttonAbout_SVE = new Button();
            buttonOpen_SVE = new Button();
            buttonDone_SVE = new Button();
            panelTask_SVE = new Panel();
            groupBoxTask_SVE = new GroupBox();
            textBoxTask_SVE = new TextBox();
            panelLeft_SVE = new Panel();
            groupBoxInput_SVE = new GroupBox();
            textBoxInput_SVE = new TextBox();
            splitterPanel_SVE = new Splitter();
            panelRight_SVE = new Panel();
            groupBoxOutput_SVE = new GroupBox();
            textBoxOutput_SVE = new TextBox();
            openFileDialog_SVE = new OpenFileDialog();
            toolTip_SVE = new ToolTip(components);
            panelTop_SVE.SuspendLayout();
            panelTask_SVE.SuspendLayout();
            groupBoxTask_SVE.SuspendLayout();
            panelLeft_SVE.SuspendLayout();
            groupBoxInput_SVE.SuspendLayout();
            panelRight_SVE.SuspendLayout();
            groupBoxOutput_SVE.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_SVE
            // 
            panelTop_SVE.BorderStyle = BorderStyle.FixedSingle;
            panelTop_SVE.Controls.Add(buttonAbout_SVE);
            panelTop_SVE.Controls.Add(buttonOpen_SVE);
            panelTop_SVE.Controls.Add(buttonDone_SVE);
            panelTop_SVE.Dock = DockStyle.Top;
            panelTop_SVE.Location = new Point(0, 0);
            panelTop_SVE.Name = "panelTop_SVE";
            panelTop_SVE.Size = new Size(882, 88);
            panelTop_SVE.TabIndex = 0;
            // 
            // buttonAbout_SVE
            // 
            buttonAbout_SVE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_SVE.BackColor = SystemColors.ButtonFace;
            buttonAbout_SVE.Image = Properties.Resources.icons8_работа_48;
            buttonAbout_SVE.Location = new Point(766, 3);
            buttonAbout_SVE.Name = "buttonAbout_SVE";
            buttonAbout_SVE.Size = new Size(111, 80);
            buttonAbout_SVE.TabIndex = 0;
            toolTip_SVE.SetToolTip(buttonAbout_SVE, "О программе");
            buttonAbout_SVE.UseVisualStyleBackColor = false;
            buttonAbout_SVE.Click += buttonAbout_SVE_Click;
            buttonAbout_SVE.MouseEnter += buttonOpen_SVE_MouseEnter;
            buttonAbout_SVE.MouseLeave += buttonOpen_SVE_MouseLeave;
            // 
            // buttonOpen_SVE
            // 
            buttonOpen_SVE.BackColor = SystemColors.ButtonFace;
            buttonOpen_SVE.Image = Properties.Resources.icons8_добавить_папку_48;
            buttonOpen_SVE.Location = new Point(3, 3);
            buttonOpen_SVE.Name = "buttonOpen_SVE";
            buttonOpen_SVE.Size = new Size(111, 80);
            buttonOpen_SVE.TabIndex = 0;
            toolTip_SVE.SetToolTip(buttonOpen_SVE, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_SVE.UseVisualStyleBackColor = false;
            buttonOpen_SVE.Click += buttonOpen_SVE_Click;
            buttonOpen_SVE.MouseEnter += buttonOpen_SVE_MouseEnter;
            buttonOpen_SVE.MouseLeave += buttonOpen_SVE_MouseLeave;
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.BackColor = SystemColors.ButtonFace;
            buttonDone_SVE.Enabled = false;
            buttonDone_SVE.Image = (Image)resources.GetObject("buttonDone_SVE.Image");
            buttonDone_SVE.Location = new Point(120, 3);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(111, 80);
            buttonDone_SVE.TabIndex = 0;
            toolTip_SVE.SetToolTip(buttonDone_SVE, "Производит поиск в файле вхождений символов \"b\"\r\nи выводит результат в поле \"Вывод\"");
            buttonDone_SVE.UseVisualStyleBackColor = false;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            buttonDone_SVE.MouseEnter += buttonOpen_SVE_MouseEnter;
            buttonDone_SVE.MouseLeave += buttonOpen_SVE_MouseLeave;
            // 
            // panelTask_SVE
            // 
            panelTask_SVE.Controls.Add(groupBoxTask_SVE);
            panelTask_SVE.Dock = DockStyle.Top;
            panelTask_SVE.Location = new Point(0, 88);
            panelTask_SVE.Name = "panelTask_SVE";
            panelTask_SVE.Size = new Size(882, 100);
            panelTask_SVE.TabIndex = 1;
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Dock = DockStyle.Fill;
            groupBoxTask_SVE.Location = new Point(0, 0);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(882, 100);
            groupBoxTask_SVE.TabIndex = 0;
            groupBoxTask_SVE.TabStop = false;
            groupBoxTask_SVE.Text = "Условие:";
            // 
            // textBoxTask_SVE
            // 
            textBoxTask_SVE.BorderStyle = BorderStyle.None;
            textBoxTask_SVE.Dock = DockStyle.Fill;
            textBoxTask_SVE.Location = new Point(3, 23);
            textBoxTask_SVE.Multiline = true;
            textBoxTask_SVE.Name = "textBoxTask_SVE";
            textBoxTask_SVE.ReadOnly = true;
            textBoxTask_SVE.Size = new Size(876, 74);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = resources.GetString("textBoxTask_SVE.Text");
            // 
            // panelLeft_SVE
            // 
            panelLeft_SVE.Controls.Add(groupBoxInput_SVE);
            panelLeft_SVE.Dock = DockStyle.Left;
            panelLeft_SVE.Location = new Point(0, 188);
            panelLeft_SVE.Name = "panelLeft_SVE";
            panelLeft_SVE.Size = new Size(443, 365);
            panelLeft_SVE.TabIndex = 2;
            // 
            // groupBoxInput_SVE
            // 
            groupBoxInput_SVE.Controls.Add(textBoxInput_SVE);
            groupBoxInput_SVE.Dock = DockStyle.Fill;
            groupBoxInput_SVE.Location = new Point(0, 0);
            groupBoxInput_SVE.Name = "groupBoxInput_SVE";
            groupBoxInput_SVE.Size = new Size(443, 365);
            groupBoxInput_SVE.TabIndex = 0;
            groupBoxInput_SVE.TabStop = false;
            groupBoxInput_SVE.Text = "Ввод:";
            // 
            // textBoxInput_SVE
            // 
            textBoxInput_SVE.Dock = DockStyle.Fill;
            textBoxInput_SVE.Location = new Point(3, 23);
            textBoxInput_SVE.Multiline = true;
            textBoxInput_SVE.Name = "textBoxInput_SVE";
            textBoxInput_SVE.ScrollBars = ScrollBars.Vertical;
            textBoxInput_SVE.Size = new Size(437, 339);
            textBoxInput_SVE.TabIndex = 0;
            // 
            // splitterPanel_SVE
            // 
            splitterPanel_SVE.Location = new Point(443, 188);
            splitterPanel_SVE.Name = "splitterPanel_SVE";
            splitterPanel_SVE.Size = new Size(4, 365);
            splitterPanel_SVE.TabIndex = 3;
            splitterPanel_SVE.TabStop = false;
            // 
            // panelRight_SVE
            // 
            panelRight_SVE.Controls.Add(groupBoxOutput_SVE);
            panelRight_SVE.Dock = DockStyle.Fill;
            panelRight_SVE.Location = new Point(447, 188);
            panelRight_SVE.Name = "panelRight_SVE";
            panelRight_SVE.Size = new Size(435, 365);
            panelRight_SVE.TabIndex = 4;
            // 
            // groupBoxOutput_SVE
            // 
            groupBoxOutput_SVE.Controls.Add(textBoxOutput_SVE);
            groupBoxOutput_SVE.Dock = DockStyle.Fill;
            groupBoxOutput_SVE.Location = new Point(0, 0);
            groupBoxOutput_SVE.Name = "groupBoxOutput_SVE";
            groupBoxOutput_SVE.Size = new Size(435, 365);
            groupBoxOutput_SVE.TabIndex = 0;
            groupBoxOutput_SVE.TabStop = false;
            groupBoxOutput_SVE.Text = "Вывод:";
            // 
            // textBoxOutput_SVE
            // 
            textBoxOutput_SVE.Dock = DockStyle.Fill;
            textBoxOutput_SVE.Location = new Point(3, 23);
            textBoxOutput_SVE.Multiline = true;
            textBoxOutput_SVE.Name = "textBoxOutput_SVE";
            textBoxOutput_SVE.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_SVE.Size = new Size(429, 339);
            textBoxOutput_SVE.TabIndex = 0;
            // 
            // openFileDialog_SVE
            // 
            openFileDialog_SVE.FileName = "openFileDialog1";
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(panelRight_SVE);
            Controls.Add(splitterPanel_SVE);
            Controls.Add(panelLeft_SVE);
            Controls.Add(panelTask_SVE);
            Controls.Add(panelTop_SVE);
            Name = "FormMain_SVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 16 | Сафронов В. Е.";
            panelTop_SVE.ResumeLayout(false);
            panelTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            panelLeft_SVE.ResumeLayout(false);
            groupBoxInput_SVE.ResumeLayout(false);
            groupBoxInput_SVE.PerformLayout();
            panelRight_SVE.ResumeLayout(false);
            groupBoxOutput_SVE.ResumeLayout(false);
            groupBoxOutput_SVE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_SVE;
        private Button buttonAbout_SVE;
        private Button buttonOpen_SVE;
        private Button buttonDone_SVE;
        private Panel panelTask_SVE;
        private Panel panelLeft_SVE;
        private Splitter splitterPanel_SVE;
        private Panel panelRight_SVE;
        private GroupBox groupBoxTask_SVE;
        private TextBox textBoxTask_SVE;
        private GroupBox groupBoxInput_SVE;
        private TextBox textBoxInput_SVE;
        private GroupBox groupBoxOutput_SVE;
        private TextBox textBoxOutput_SVE;
        private OpenFileDialog openFileDialog_SVE;
        private ToolTip toolTip_SVE;
    }
}
