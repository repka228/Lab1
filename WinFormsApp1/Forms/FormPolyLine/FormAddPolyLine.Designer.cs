namespace WinFormsApp1.Forms
{
    partial class FormAddPolyLine
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
            listBoxLines = new ListBox();
            buttonAddLine = new Button();
            buttonChangeLine = new Button();
            buttonDeleteLine = new Button();
            buttonChooseColor = new Button();
            panelPolyLineColor = new Panel();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(69, 299);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(69, 328);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // listBoxLines
            // 
            listBoxLines.FormattingEnabled = true;
            listBoxLines.ItemHeight = 15;
            listBoxLines.Location = new Point(12, 99);
            listBoxLines.Name = "listBoxLines";
            listBoxLines.Size = new Size(211, 139);
            listBoxLines.TabIndex = 2;
            // 
            // buttonAddLine
            // 
            buttonAddLine.Location = new Point(47, 12);
            buttonAddLine.Name = "buttonAddLine";
            buttonAddLine.Size = new Size(120, 23);
            buttonAddLine.TabIndex = 3;
            buttonAddLine.Text = "Добавить линию";
            buttonAddLine.UseVisualStyleBackColor = true;
            buttonAddLine.Click += buttonAddLine_Click;
            // 
            // buttonChangeLine
            // 
            buttonChangeLine.Location = new Point(47, 41);
            buttonChangeLine.Name = "buttonChangeLine";
            buttonChangeLine.Size = new Size(120, 23);
            buttonChangeLine.TabIndex = 5;
            buttonChangeLine.Text = "Изменить линию";
            buttonChangeLine.UseVisualStyleBackColor = true;
            buttonChangeLine.Click += buttonChangeLine_Click;
            // 
            // buttonDeleteLine
            // 
            buttonDeleteLine.Location = new Point(47, 70);
            buttonDeleteLine.Name = "buttonDeleteLine";
            buttonDeleteLine.Size = new Size(120, 23);
            buttonDeleteLine.TabIndex = 6;
            buttonDeleteLine.Text = "Удалить линию";
            buttonDeleteLine.UseVisualStyleBackColor = true;
            buttonDeleteLine.Click += buttonDeleteLine_Click;
            // 
            // buttonChooseColor
            // 
            buttonChooseColor.Location = new Point(26, 252);
            buttonChooseColor.Name = "buttonChooseColor";
            buttonChooseColor.Size = new Size(75, 41);
            buttonChooseColor.TabIndex = 7;
            buttonChooseColor.Text = "Выбрать цвет";
            buttonChooseColor.UseVisualStyleBackColor = true;
            buttonChooseColor.Click += buttonChooseColor_Click;
            // 
            // panelPolyLineColor
            // 
            panelPolyLineColor.Location = new Point(126, 252);
            panelPolyLineColor.Name = "panelPolyLineColor";
            panelPolyLineColor.Size = new Size(41, 41);
            panelPolyLineColor.TabIndex = 8;
            // 
            // FormAddPolyLine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 364);
            Controls.Add(panelPolyLineColor);
            Controls.Add(buttonChooseColor);
            Controls.Add(buttonDeleteLine);
            Controls.Add(buttonChangeLine);
            Controls.Add(buttonAddLine);
            Controls.Add(listBoxLines);
            Controls.Add(buttonExit);
            Controls.Add(buttonSave);
            Name = "FormAddPolyLine";
            Text = "FormAddPolyLine";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSave;
        private Button buttonExit;
        private ListBox listBoxLines;
        private Button buttonAddLine;
        private Button buttonChangeLine;
        private Button buttonDeleteLine;
        private Button buttonChooseColor;
        private Panel panelPolyLineColor;
    }
}