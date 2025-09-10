namespace WinFormsApp1.Forms.FormPolyLine
{
    partial class FormScalePolyLine
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
            buttonScale = new Button();
            buttonExit = new Button();
            numericUpDownScaleFactor = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScaleFactor).BeginInit();
            SuspendLayout();
            // 
            // buttonScale
            // 
            buttonScale.Anchor = AnchorStyles.Bottom;
            buttonScale.Location = new Point(55, 41);
            buttonScale.Name = "buttonScale";
            buttonScale.Size = new Size(120, 23);
            buttonScale.TabIndex = 0;
            buttonScale.Text = "Масштабировать";
            buttonScale.UseVisualStyleBackColor = true;
            buttonScale.Click += buttonScale_Click;
            // 
            // buttonExit
            // 
            buttonExit.Anchor = AnchorStyles.Bottom;
            buttonExit.Location = new Point(76, 70);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // numericUpDownScaleFactor
            // 
            numericUpDownScaleFactor.Anchor = AnchorStyles.Top;
            numericUpDownScaleFactor.Location = new Point(55, 12);
            numericUpDownScaleFactor.Name = "numericUpDownScaleFactor";
            numericUpDownScaleFactor.Size = new Size(120, 23);
            numericUpDownScaleFactor.TabIndex = 2;
            // 
            // FormScalePolyLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 114);
            Controls.Add(numericUpDownScaleFactor);
            Controls.Add(buttonExit);
            Controls.Add(buttonScale);
            Name = "FormScalePolyLine";
            Text = "FormScalePolyLine";
            ((System.ComponentModel.ISupportInitialize)numericUpDownScaleFactor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonScale;
        private Button buttonExit;
        private NumericUpDown numericUpDownScaleFactor;
    }
}