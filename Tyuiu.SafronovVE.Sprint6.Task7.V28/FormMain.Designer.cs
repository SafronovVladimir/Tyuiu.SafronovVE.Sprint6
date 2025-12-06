namespace Tyuiu.SafronovVE.Sprint6.Task7.V28
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
            buttonHelp_SVE = new Button();
            buttonSave_SVE = new Button();
            buttonDone_SVE = new Button();
            buttonOpen_SVE = new Button();
            panelTask_SVE = new Panel();
            groupBoxTask_SVE = new GroupBox();
            textBoxTask_SVE = new TextBox();
            panelLeft_SVE = new Panel();
            groupBoxInput_SVE = new GroupBox();
            dataGridViewIn_SVE = new DataGridView();
            splitterPanel_SVE = new Splitter();
            panelRight_SVE = new Panel();
            groupBoxOutput_SVE = new GroupBox();
            dataGridViewOut_SVE = new DataGridView();
            toolTip_SVE = new ToolTip(components);
            openFileDialog_SVE = new OpenFileDialog();
            saveFileDialog_SVE = new SaveFileDialog();
            panelTop_SVE.SuspendLayout();
            panelTask_SVE.SuspendLayout();
            groupBoxTask_SVE.SuspendLayout();
            panelLeft_SVE.SuspendLayout();
            groupBoxInput_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SVE).BeginInit();
            panelRight_SVE.SuspendLayout();
            groupBoxOutput_SVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SVE).BeginInit();
            SuspendLayout();
            // 
            // panelTop_SVE
            // 
            panelTop_SVE.BorderStyle = BorderStyle.FixedSingle;
            panelTop_SVE.Controls.Add(buttonHelp_SVE);
            panelTop_SVE.Controls.Add(buttonSave_SVE);
            panelTop_SVE.Controls.Add(buttonDone_SVE);
            panelTop_SVE.Controls.Add(buttonOpen_SVE);
            panelTop_SVE.Dock = DockStyle.Top;
            panelTop_SVE.Location = new Point(0, 0);
            panelTop_SVE.Name = "panelTop_SVE";
            panelTop_SVE.Size = new Size(938, 88);
            panelTop_SVE.TabIndex = 0;
            // 
            // buttonHelp_SVE
            // 
            buttonHelp_SVE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SVE.BackColor = SystemColors.ButtonFace;
            buttonHelp_SVE.Image = Properties.Resources.icons8_работа_48;
            buttonHelp_SVE.Location = new Point(839, 3);
            buttonHelp_SVE.Name = "buttonHelp_SVE";
            buttonHelp_SVE.Size = new Size(94, 78);
            buttonHelp_SVE.TabIndex = 0;
            toolTip_SVE.SetToolTip(buttonHelp_SVE, "О программе");
            buttonHelp_SVE.UseVisualStyleBackColor = false;
            buttonHelp_SVE.Click += buttonHelp_SVE_Click;
            buttonHelp_SVE.MouseEnter += buttonOpen_SVE_MouseEnter;
            buttonHelp_SVE.MouseLeave += buttonOpen_SVE_MouseLeave;
            // 
            // buttonSave_SVE
            // 
            buttonSave_SVE.BackColor = SystemColors.ButtonFace;
            buttonSave_SVE.Image = Properties.Resources.icons8_скопировать_48;
            buttonSave_SVE.Location = new Point(203, 3);
            buttonSave_SVE.Name = "buttonSave_SVE";
            buttonSave_SVE.Size = new Size(94, 78);
            buttonSave_SVE.TabIndex = 0;
            toolTip_SVE.SetToolTip(buttonSave_SVE, "Сохранить файл\r\nВыберите место для сохранения обработанного файла");
            buttonSave_SVE.UseVisualStyleBackColor = false;
            buttonSave_SVE.Click += buttonSave_SVE_Click;
            buttonSave_SVE.MouseEnter += buttonOpen_SVE_MouseEnter;
            buttonSave_SVE.MouseLeave += buttonOpen_SVE_MouseLeave;
            // 
            // buttonDone_SVE
            // 
            buttonDone_SVE.BackColor = SystemColors.ButtonFace;
            buttonDone_SVE.Image = Properties.Resources.icons8_документы_48;
            buttonDone_SVE.Location = new Point(103, 3);
            buttonDone_SVE.Name = "buttonDone_SVE";
            buttonDone_SVE.Size = new Size(94, 78);
            buttonDone_SVE.TabIndex = 0;
            toolTip_SVE.SetToolTip(buttonDone_SVE, "Выполнить замену чисел в седьмой строке не равных 13 на 0.\r\nВывести результат в поле \"Вывод\"");
            buttonDone_SVE.UseVisualStyleBackColor = false;
            buttonDone_SVE.Click += buttonDone_SVE_Click;
            buttonDone_SVE.MouseEnter += buttonOpen_SVE_MouseEnter;
            buttonDone_SVE.MouseLeave += buttonOpen_SVE_MouseLeave;
            // 
            // buttonOpen_SVE
            // 
            buttonOpen_SVE.BackColor = SystemColors.ButtonFace;
            buttonOpen_SVE.Image = Properties.Resources.icons8_добавить_папку_48;
            buttonOpen_SVE.Location = new Point(3, 3);
            buttonOpen_SVE.Name = "buttonOpen_SVE";
            buttonOpen_SVE.Size = new Size(94, 78);
            buttonOpen_SVE.TabIndex = 0;
            toolTip_SVE.SetToolTip(buttonOpen_SVE, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_SVE.UseVisualStyleBackColor = false;
            buttonOpen_SVE.Click += buttonOpen_SVE_Click;
            buttonOpen_SVE.MouseEnter += buttonOpen_SVE_MouseEnter;
            buttonOpen_SVE.MouseLeave += buttonOpen_SVE_MouseLeave;
            // 
            // panelTask_SVE
            // 
            panelTask_SVE.Controls.Add(groupBoxTask_SVE);
            panelTask_SVE.Dock = DockStyle.Top;
            panelTask_SVE.Location = new Point(0, 88);
            panelTask_SVE.Name = "panelTask_SVE";
            panelTask_SVE.Size = new Size(938, 92);
            panelTask_SVE.TabIndex = 1;
            // 
            // groupBoxTask_SVE
            // 
            groupBoxTask_SVE.Controls.Add(textBoxTask_SVE);
            groupBoxTask_SVE.Dock = DockStyle.Fill;
            groupBoxTask_SVE.Location = new Point(0, 0);
            groupBoxTask_SVE.Name = "groupBoxTask_SVE";
            groupBoxTask_SVE.Size = new Size(938, 92);
            groupBoxTask_SVE.TabIndex = 0;
            groupBoxTask_SVE.TabStop = false;
            groupBoxTask_SVE.Text = "Условие:";
            // 
            // textBoxTask_SVE
            // 
            textBoxTask_SVE.Dock = DockStyle.Fill;
            textBoxTask_SVE.Location = new Point(3, 23);
            textBoxTask_SVE.Multiline = true;
            textBoxTask_SVE.Name = "textBoxTask_SVE";
            textBoxTask_SVE.ReadOnly = true;
            textBoxTask_SVE.Size = new Size(932, 66);
            textBoxTask_SVE.TabIndex = 0;
            textBoxTask_SVE.Text = resources.GetString("textBoxTask_SVE.Text");
            // 
            // panelLeft_SVE
            // 
            panelLeft_SVE.Controls.Add(groupBoxInput_SVE);
            panelLeft_SVE.Dock = DockStyle.Left;
            panelLeft_SVE.Location = new Point(0, 180);
            panelLeft_SVE.Name = "panelLeft_SVE";
            panelLeft_SVE.Size = new Size(470, 463);
            panelLeft_SVE.TabIndex = 2;
            // 
            // groupBoxInput_SVE
            // 
            groupBoxInput_SVE.Controls.Add(dataGridViewIn_SVE);
            groupBoxInput_SVE.Dock = DockStyle.Fill;
            groupBoxInput_SVE.Location = new Point(0, 0);
            groupBoxInput_SVE.Name = "groupBoxInput_SVE";
            groupBoxInput_SVE.Size = new Size(470, 463);
            groupBoxInput_SVE.TabIndex = 0;
            groupBoxInput_SVE.TabStop = false;
            groupBoxInput_SVE.Text = "Ввод:";
            // 
            // dataGridViewIn_SVE
            // 
            dataGridViewIn_SVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_SVE.ColumnHeadersVisible = false;
            dataGridViewIn_SVE.Dock = DockStyle.Fill;
            dataGridViewIn_SVE.Location = new Point(3, 23);
            dataGridViewIn_SVE.Name = "dataGridViewIn_SVE";
            dataGridViewIn_SVE.RowHeadersVisible = false;
            dataGridViewIn_SVE.RowHeadersWidth = 51;
            dataGridViewIn_SVE.Size = new Size(464, 437);
            dataGridViewIn_SVE.TabIndex = 0;
            // 
            // splitterPanel_SVE
            // 
            splitterPanel_SVE.Location = new Point(470, 180);
            splitterPanel_SVE.Name = "splitterPanel_SVE";
            splitterPanel_SVE.Size = new Size(4, 463);
            splitterPanel_SVE.TabIndex = 3;
            splitterPanel_SVE.TabStop = false;
            // 
            // panelRight_SVE
            // 
            panelRight_SVE.Controls.Add(groupBoxOutput_SVE);
            panelRight_SVE.Dock = DockStyle.Fill;
            panelRight_SVE.Location = new Point(474, 180);
            panelRight_SVE.Name = "panelRight_SVE";
            panelRight_SVE.Size = new Size(464, 463);
            panelRight_SVE.TabIndex = 4;
            // 
            // groupBoxOutput_SVE
            // 
            groupBoxOutput_SVE.Controls.Add(dataGridViewOut_SVE);
            groupBoxOutput_SVE.Dock = DockStyle.Fill;
            groupBoxOutput_SVE.Location = new Point(0, 0);
            groupBoxOutput_SVE.Name = "groupBoxOutput_SVE";
            groupBoxOutput_SVE.Size = new Size(464, 463);
            groupBoxOutput_SVE.TabIndex = 0;
            groupBoxOutput_SVE.TabStop = false;
            groupBoxOutput_SVE.Text = "Вывод:";
            // 
            // dataGridViewOut_SVE
            // 
            dataGridViewOut_SVE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_SVE.ColumnHeadersVisible = false;
            dataGridViewOut_SVE.Dock = DockStyle.Fill;
            dataGridViewOut_SVE.Location = new Point(3, 23);
            dataGridViewOut_SVE.Name = "dataGridViewOut_SVE";
            dataGridViewOut_SVE.RowHeadersVisible = false;
            dataGridViewOut_SVE.RowHeadersWidth = 51;
            dataGridViewOut_SVE.Size = new Size(458, 437);
            dataGridViewOut_SVE.TabIndex = 0;
            // 
            // toolTip_SVE
            // 
            toolTip_SVE.IsBalloon = true;
            toolTip_SVE.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_SVE
            // 
            openFileDialog_SVE.FileName = "openFileDialog1";
            // 
            // FormMain_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 643);
            Controls.Add(panelRight_SVE);
            Controls.Add(splitterPanel_SVE);
            Controls.Add(panelLeft_SVE);
            Controls.Add(panelTask_SVE);
            Controls.Add(panelTop_SVE);
            Name = "FormMain_SVE";
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Сафронов В. Е.";
            Load += FormMain_SVE_Load;
            panelTop_SVE.ResumeLayout(false);
            panelTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.ResumeLayout(false);
            groupBoxTask_SVE.PerformLayout();
            panelLeft_SVE.ResumeLayout(false);
            groupBoxInput_SVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_SVE).EndInit();
            panelRight_SVE.ResumeLayout(false);
            groupBoxOutput_SVE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_SVE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_SVE;
        private Panel panelTask_SVE;
        private Panel panelLeft_SVE;
        private Splitter splitterPanel_SVE;
        private Panel panelRight_SVE;
        private Button buttonHelp_SVE;
        private Button buttonSave_SVE;
        private Button buttonDone_SVE;
        private Button buttonOpen_SVE;
        private GroupBox groupBoxTask_SVE;
        private TextBox textBoxTask_SVE;
        private GroupBox groupBoxInput_SVE;
        private DataGridView dataGridViewIn_SVE;
        private GroupBox groupBoxOutput_SVE;
        private DataGridView dataGridViewOut_SVE;
        private ToolTip toolTip_SVE;
        private OpenFileDialog openFileDialog_SVE;
        private SaveFileDialog saveFileDialog_SVE;
    }
}
