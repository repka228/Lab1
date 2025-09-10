namespace WinFormsApp1.Forms
{
    partial class FormOffsetLine
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
            buttonOffset = new Button();
            buttonExit = new Button();
            numericUpDownDegrees = new NumericUpDown();
            numericUpDownDistance = new NumericUpDown();
            labelDistance = new Label();
            labelDegrees = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDegrees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).BeginInit();
            SuspendLayout();
            // 
            // buttonOffset
            // 
            buttonOffset.Location = new Point(56, 83);
            buttonOffset.Name = "buttonOffset";
            buttonOffset.Size = new Size(75, 23);
            buttonOffset.TabIndex = 0;
            buttonOffset.Text = "Сместить";
            buttonOffset.UseVisualStyleBackColor = true;
            buttonOffset.Click += buttonOffsetByAngle_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(56, 112);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // numericUpDownDegrees
            // 
            numericUpDownDegrees.Location = new Point(84, 40);
            numericUpDownDegrees.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownDegrees.Name = "numericUpDownDegrees";
            numericUpDownDegrees.Size = new Size(120, 23);
            numericUpDownDegrees.TabIndex = 2;
            // 
            // numericUpDownDistance
            // 
            numericUpDownDistance.Location = new Point(84, 7);
            numericUpDownDistance.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDownDistance.Name = "numericUpDownDistance";
            numericUpDownDistance.Size = new Size(120, 23);
            numericUpDownDistance.TabIndex = 3;
            // 
            // labelDistance
            // 
            labelDistance.AutoSize = true;
            labelDistance.Location = new Point(12, 9);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(66, 15);
            labelDistance.TabIndex = 4;
            labelDistance.Text = "Дистанция";
            // 
            // labelDegrees
            // 
            labelDegrees.AutoSize = true;
            labelDegrees.Location = new Point(12, 42);
            labelDegrees.Name = "labelDegrees";
            labelDegrees.Size = new Size(33, 15);
            labelDegrees.TabIndex = 5;
            labelDegrees.Text = "Угол";
            // 
            // FormOffsetLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 165);
            Controls.Add(labelDegrees);
            Controls.Add(labelDistance);
            Controls.Add(numericUpDownDistance);
            Controls.Add(numericUpDownDegrees);
            Controls.Add(buttonExit);
            Controls.Add(buttonOffset);
            Name = "FormOffsetLine";
            Text = "OffsetLine";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDegrees).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDistance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOffset;
        private Button buttonExit;
        private NumericUpDown numericUpDownDegrees;
        private NumericUpDown numericUpDownDistance;
        private Label labelDistance;
        private Label labelDegrees;
    }
}