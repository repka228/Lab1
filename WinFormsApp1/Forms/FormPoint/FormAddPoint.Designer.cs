namespace WinFormsApp1.Forms
{
    partial class FormAddPoint
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
            buttonAddPoint = new Button();
            buttonExit = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            labelX = new Label();
            labelY = new Label();
            colorDialogPoint = new ColorDialog();
            chooseColorButton = new Button();
            panelColorPoint = new Panel();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // buttonAddPoint
            // 
            buttonAddPoint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonAddPoint.Location = new Point(12, 155);
            buttonAddPoint.Name = "buttonAddPoint";
            buttonAddPoint.Size = new Size(103, 23);
            buttonAddPoint.TabIndex = 0;
            buttonAddPoint.Text = "Сохранить точку";
            buttonAddPoint.UseVisualStyleBackColor = true;
            buttonAddPoint.Click += buttonAddPoint_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonExit.Location = new Point(23, 184);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.Left;
            numericUpDown1.Location = new Point(32, 63);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(57, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(32, 28);
            numericUpDown2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(57, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(12, 30);
            labelX.Name = "labelX";
            labelX.Size = new Size(14, 15);
            labelX.TabIndex = 4;
            labelX.Text = "X";
            // 
            // labelY
            // 
            labelY.Anchor = AnchorStyles.Left;
            labelY.AutoSize = true;
            labelY.Location = new Point(12, 65);
            labelY.Name = "labelY";
            labelY.Size = new Size(14, 15);
            labelY.TabIndex = 5;
            labelY.Text = "Y";
            // 
            // chooseColorButton
            // 
            chooseColorButton.Anchor = AnchorStyles.Left;
            chooseColorButton.Location = new Point(12, 92);
            chooseColorButton.Name = "chooseColorButton";
            chooseColorButton.Size = new Size(75, 47);
            chooseColorButton.TabIndex = 6;
            chooseColorButton.Text = "Выбрать цвет";
            chooseColorButton.UseVisualStyleBackColor = true;
            chooseColorButton.Click += chooseColorButton_Click;
            // 
            // panelColorPoint
            // 
            panelColorPoint.Anchor = AnchorStyles.Right;
            panelColorPoint.Location = new Point(93, 92);
            panelColorPoint.Name = "panelColorPoint";
            panelColorPoint.Size = new Size(56, 47);
            panelColorPoint.TabIndex = 7;
            // 
            // FormAddPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(173, 236);
            Controls.Add(panelColorPoint);
            Controls.Add(chooseColorButton);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonExit);
            Controls.Add(buttonAddPoint);
            Name = "FormAddPoint";
            Text = "Points";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddPoint;
        private Button buttonExit;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label labelX;
        private Label labelY;
        private ColorDialog colorDialogPoint;
        private Button chooseColorButton;
        private Panel panelColorPoint;
    }
}