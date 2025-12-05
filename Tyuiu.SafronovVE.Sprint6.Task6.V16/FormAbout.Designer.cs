namespace Tyuiu.SafronovVE.Sprint6.Task6.V16
{
    partial class FormAbout_SVE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_SVE));
            pictureBoxAvatar_SVE = new PictureBox();
            labelInfo_SVE = new Label();
            buttonOK_SVE = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SVE).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_SVE
            // 
            pictureBoxAvatar_SVE.Image = Properties.Resources.photo_2025_10_11_16_41_40;
            pictureBoxAvatar_SVE.Location = new Point(12, 12);
            pictureBoxAvatar_SVE.Name = "pictureBoxAvatar_SVE";
            pictureBoxAvatar_SVE.Size = new Size(176, 222);
            pictureBoxAvatar_SVE.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_SVE.TabIndex = 0;
            pictureBoxAvatar_SVE.TabStop = false;
            // 
            // labelInfo_SVE
            // 
            labelInfo_SVE.AutoSize = true;
            labelInfo_SVE.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_SVE.Location = new Point(194, 12);
            labelInfo_SVE.Name = "labelInfo_SVE";
            labelInfo_SVE.Size = new Size(387, 180);
            labelInfo_SVE.TabIndex = 1;
            labelInfo_SVE.Text = resources.GetString("labelInfo_SVE.Text");
            // 
            // buttonOK_SVE
            // 
            buttonOK_SVE.Location = new Point(498, 205);
            buttonOK_SVE.Name = "buttonOK_SVE";
            buttonOK_SVE.Size = new Size(102, 29);
            buttonOK_SVE.TabIndex = 2;
            buttonOK_SVE.Text = "Ok";
            buttonOK_SVE.UseVisualStyleBackColor = true;
            buttonOK_SVE.Click += buttonOK_SVE_Click;
            // 
            // FormAbout_SVE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 253);
            Controls.Add(buttonOK_SVE);
            Controls.Add(labelInfo_SVE);
            Controls.Add(pictureBoxAvatar_SVE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAbout_SVE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SVE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_SVE;
        private Label labelInfo_SVE;
        private Button buttonOK_SVE;
    }
}