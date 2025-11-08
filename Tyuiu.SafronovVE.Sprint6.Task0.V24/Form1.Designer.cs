namespace Tyuiu.SafronovVE.Sprint6.Task0.V24
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
            formulaPicture = new PictureBox();
            condition = new GroupBox();
            conditionText = new Label();
            inputData = new GroupBox();
            varX = new TextBox();
            labelVarX = new Label();
            outputData = new GroupBox();
            result = new TextBox();
            resultText = new Label();
            completeOperation = new Button();
            ((System.ComponentModel.ISupportInitialize)formulaPicture).BeginInit();
            condition.SuspendLayout();
            inputData.SuspendLayout();
            outputData.SuspendLayout();
            SuspendLayout();
            // 
            // formulaPicture
            // 
            formulaPicture.BorderStyle = BorderStyle.FixedSingle;
            formulaPicture.Image = Properties.Resources.unnamed;
            formulaPicture.Location = new Point(303, 26);
            formulaPicture.Name = "formulaPicture";
            formulaPicture.Size = new Size(193, 78);
            formulaPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            formulaPicture.TabIndex = 0;
            formulaPicture.TabStop = false;
            // 
            // condition
            // 
            condition.Controls.Add(conditionText);
            condition.Controls.Add(formulaPicture);
            condition.Location = new Point(12, 61);
            condition.Name = "condition";
            condition.Size = new Size(517, 140);
            condition.TabIndex = 1;
            condition.TabStop = false;
            condition.Tag = "ыфв";
            condition.Text = "Условие";
            // 
            // conditionText
            // 
            conditionText.AutoSize = true;
            conditionText.Location = new Point(6, 55);
            conditionText.Name = "conditionText";
            conditionText.Size = new Size(260, 20);
            conditionText.TabIndex = 2;
            conditionText.Text = "Вычислить выражение по формуле:";
            // 
            // inputData
            // 
            inputData.Controls.Add(varX);
            inputData.Controls.Add(labelVarX);
            inputData.Location = new Point(12, 207);
            inputData.Name = "inputData";
            inputData.Size = new Size(266, 125);
            inputData.TabIndex = 2;
            inputData.TabStop = false;
            inputData.Text = "Ввод данных";
            // 
            // varX
            // 
            varX.Location = new Point(18, 70);
            varX.Name = "varX";
            varX.Size = new Size(114, 27);
            varX.TabIndex = 1;
            // 
            // labelVarX
            // 
            labelVarX.AutoSize = true;
            labelVarX.Location = new Point(18, 36);
            labelVarX.Name = "labelVarX";
            labelVarX.Size = new Size(114, 20);
            labelVarX.TabIndex = 0;
            labelVarX.Text = "Переменная X:";
            // 
            // outputData
            // 
            outputData.Controls.Add(result);
            outputData.Controls.Add(resultText);
            outputData.Location = new Point(284, 207);
            outputData.Name = "outputData";
            outputData.Size = new Size(245, 125);
            outputData.TabIndex = 3;
            outputData.TabStop = false;
            outputData.Text = "Вывод данных";
            // 
            // result
            // 
            result.Location = new Point(15, 70);
            result.Name = "result";
            result.Size = new Size(193, 27);
            result.TabIndex = 1;
            // 
            // resultText
            // 
            resultText.AutoSize = true;
            resultText.Location = new Point(15, 36);
            resultText.Name = "resultText";
            resultText.Size = new Size(78, 20);
            resultText.TabIndex = 0;
            resultText.Text = "Результат:";
            // 
            // completeOperation
            // 
            completeOperation.Location = new Point(408, 338);
            completeOperation.Name = "completeOperation";
            completeOperation.Size = new Size(121, 45);
            completeOperation.TabIndex = 4;
            completeOperation.Text = "Выполнить";
            completeOperation.UseVisualStyleBackColor = true;
            completeOperation.Click += completeOperation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 409);
            Controls.Add(completeOperation);
            Controls.Add(outputData);
            Controls.Add(inputData);
            Controls.Add(condition);
            Name = "Form1";
            Text = "Sprint 6 | Task 0 | V24 | Safronov V.E.";
            ((System.ComponentModel.ISupportInitialize)formulaPicture).EndInit();
            condition.ResumeLayout(false);
            condition.PerformLayout();
            inputData.ResumeLayout(false);
            inputData.PerformLayout();
            outputData.ResumeLayout(false);
            outputData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox formulaPicture;
        private GroupBox condition;
        private Label conditionText;
        private GroupBox inputData;
        private Label labelVarX;
        private TextBox varX;
        private GroupBox outputData;
        private TextBox result;
        private Label resultText;
        private Button completeOperation;
    }
}
