namespace WinFormsApp1.Forms
{
    public partial class FormAddLine
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
            buttonSave = new Button();
            buttonExit = new Button();
            numericUpDownY2 = new NumericUpDown();
            numericUpDownX2 = new NumericUpDown();
            numericUpDownX1 = new NumericUpDown();
            numericUpDownY1 = new NumericUpDown();
            labelX = new Label();
            labelY = new Label();
            labelPointFirst = new Label();
            labelPointSecond = new Label();
            panelColorLine = new Panel();
            buttonChooseColor = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(126, 186);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(126, 215);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // numericUpDownY2
            // 
            numericUpDownY2.Location = new Point(211, 58);
            numericUpDownY2.Name = "numericUpDownY2";
            numericUpDownY2.Size = new Size(120, 23);
            numericUpDownY2.TabIndex = 2;
            // 
            // numericUpDownX2
            // 
            numericUpDownX2.Location = new Point(211, 27);
            numericUpDownX2.Name = "numericUpDownX2";
            numericUpDownX2.Size = new Size(120, 23);
            numericUpDownX2.TabIndex = 3;
            // 
            // numericUpDownX1
            // 
            numericUpDownX1.Location = new Point(56, 27);
            numericUpDownX1.Name = "numericUpDownX1";
            numericUpDownX1.Size = new Size(120, 23);
            numericUpDownX1.TabIndex = 4;
            // 
            // numericUpDownY1
            // 
            numericUpDownY1.Location = new Point(56, 58);
            numericUpDownY1.Name = "numericUpDownY1";
            numericUpDownY1.Size = new Size(120, 23);
            numericUpDownY1.TabIndex = 5;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(36, 29);
            labelX.Name = "labelX";
            labelX.Size = new Size(14, 15);
            labelX.TabIndex = 6;
            labelX.Text = "X";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(36, 60);
            labelY.Name = "labelY";
            labelY.Size = new Size(14, 15);
            labelY.TabIndex = 7;
            labelY.Text = "Y";
            // 
            // labelPointFirst
            // 
            labelPointFirst.AutoSize = true;
            labelPointFirst.Location = new Point(83, 9);
            labelPointFirst.Name = "labelPointFirst";
            labelPointFirst.Size = new Size(48, 15);
            labelPointFirst.TabIndex = 8;
            labelPointFirst.Text = "Точка 1";
            // 
            // labelPointSecond
            // 
            labelPointSecond.AutoSize = true;
            labelPointSecond.Location = new Point(240, 9);
            labelPointSecond.Name = "labelPointSecond";
            labelPointSecond.Size = new Size(48, 15);
            labelPointSecond.TabIndex = 9;
            labelPointSecond.Text = "Точка 2";
            // 
            // panelColorLine
            // 
            panelColorLine.Location = new Point(183, 115);
            panelColorLine.Name = "panelColorLine";
            panelColorLine.Size = new Size(47, 45);
            panelColorLine.TabIndex = 10;
            // 
            // buttonChooseColor
            // 
            buttonChooseColor.Location = new Point(83, 115);
            buttonChooseColor.Name = "buttonChooseColor";
            buttonChooseColor.Size = new Size(75, 45);
            buttonChooseColor.TabIndex = 0;
            buttonChooseColor.Text = "Выбрать цвет";
            buttonChooseColor.UseVisualStyleBackColor = true;
            buttonChooseColor.Click += buttonChooseColor_Click;
            // 
            // AddLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 257);
            Controls.Add(buttonChooseColor);
            Controls.Add(panelColorLine);
            Controls.Add(labelPointSecond);
            Controls.Add(labelPointFirst);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(numericUpDownY1);
            Controls.Add(numericUpDownX1);
            Controls.Add(numericUpDownX2);
            Controls.Add(numericUpDownY2);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Name = "AddLine";
            Text = "Lines";
            ((System.ComponentModel.ISupportInitialize)numericUpDownY2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonExit;
        private NumericUpDown numericUpDownY2;
        private NumericUpDown numericUpDownX2;
        private NumericUpDown numericUpDownX1;
        private NumericUpDown numericUpDownY1;
        private Label labelX;
        private Label labelY;
        private Label labelPointFirst;
        private Label labelPointSecond;
        public Panel panelColorLine;
        public Button buttonChooseColor;
    }
}