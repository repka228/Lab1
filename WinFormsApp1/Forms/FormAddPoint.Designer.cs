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
            buttonAddPoint.Location = new Point(56, 172);
            buttonAddPoint.Name = "buttonAddPoint";
            buttonAddPoint.Size = new Size(103, 23);
            buttonAddPoint.TabIndex = 0;
            buttonAddPoint.Text = "Сохранить точку";
            buttonAddPoint.UseVisualStyleBackColor = true;
            buttonAddPoint.Click += buttonAddPoint_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(73, 201);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(56, 65);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(56, 28);
            numericUpDown2.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 3;
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(12, 30);
            labelX.Name = "labelX";
            labelX.Size = new Size(38, 15);
            labelX.TabIndex = 4;
            labelX.Text = "label1";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(12, 65);
            labelY.Name = "labelY";
            labelY.Size = new Size(38, 15);
            labelY.TabIndex = 5;
            labelY.Text = "label2";
            // 
            // chooseColorButton
            // 
            chooseColorButton.Location = new Point(12, 108);
            chooseColorButton.Name = "chooseColorButton";
            chooseColorButton.Size = new Size(75, 47);
            chooseColorButton.TabIndex = 6;
            chooseColorButton.Text = "Выбрать цвет";
            chooseColorButton.UseVisualStyleBackColor = true;
            chooseColorButton.Click += chooseColorButton_Click;
            // 
            // panelColorPoint
            // 
            panelColorPoint.Location = new Point(120, 108);
            panelColorPoint.Name = "panelColorPoint";
            panelColorPoint.Size = new Size(56, 47);
            panelColorPoint.TabIndex = 7;
            // 
            // AddPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 236);
            Controls.Add(panelColorPoint);
            Controls.Add(chooseColorButton);
            Controls.Add(labelY);
            Controls.Add(labelX);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonExit);
            Controls.Add(buttonAddPoint);
            Name = "AddPoint";
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