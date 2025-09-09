namespace WinFormsApp1
{
    partial class Main
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
            listBoxPoint = new ListBox();
            listBoxLines = new ListBox();
            listBoxPolyLines = new ListBox();
            addPoint = new Button();
            changePoint = new Button();
            DeletePoint = new Button();
            addLine = new Button();
            changeLine = new Button();
            deleteLine = new Button();
            addPolyLine = new Button();
            changePolyLine = new Button();
            deletePolyLine = new Button();
            panelPointsTools = new Panel();
            panelPolyLinesTools = new Panel();
            panelLinesTools = new Panel();
            panelPointsTools.SuspendLayout();
            panelPolyLinesTools.SuspendLayout();
            panelLinesTools.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPoint
            // 
            listBoxPoint.FormattingEnabled = true;
            listBoxPoint.ItemHeight = 15;
            listBoxPoint.Location = new Point(12, 118);
            listBoxPoint.Name = "listBoxPoint";
            listBoxPoint.Size = new Size(193, 319);
            listBoxPoint.TabIndex = 0;
            // 
            // listBoxLines
            // 
            listBoxLines.FormattingEnabled = true;
            listBoxLines.ItemHeight = 15;
            listBoxLines.Location = new Point(299, 120);
            listBoxLines.Name = "listBoxLines";
            listBoxLines.Size = new Size(209, 319);
            listBoxLines.TabIndex = 1;
            // 
            // listBoxPolyLines
            // 
            listBoxPolyLines.FormattingEnabled = true;
            listBoxPolyLines.ItemHeight = 15;
            listBoxPolyLines.Location = new Point(542, 120);
            listBoxPolyLines.Name = "listBoxPolyLines";
            listBoxPolyLines.Size = new Size(216, 319);
            listBoxPolyLines.TabIndex = 2;
            // 
            // addPoint
            // 
            addPoint.Location = new Point(4, 3);
            addPoint.Name = "addPoint";
            addPoint.Size = new Size(193, 23);
            addPoint.TabIndex = 3;
            addPoint.Text = "Добавить точку";
            addPoint.UseVisualStyleBackColor = true;
            addPoint.Click += addPoint_Click;
            // 
            // changePoint
            // 
            changePoint.Location = new Point(4, 32);
            changePoint.Name = "changePoint";
            changePoint.Size = new Size(193, 23);
            changePoint.TabIndex = 4;
            changePoint.Text = "Изменить точку";
            changePoint.UseVisualStyleBackColor = true;
            changePoint.Click += changePoint_Click;
            // 
            // DeletePoint
            // 
            DeletePoint.Location = new Point(4, 61);
            DeletePoint.Name = "DeletePoint";
            DeletePoint.Size = new Size(193, 23);
            DeletePoint.TabIndex = 5;
            DeletePoint.Text = "Удалить точку";
            DeletePoint.UseVisualStyleBackColor = true;
            DeletePoint.Click += DeletePoint_Click;
            // 
            // addLine
            // 
            addLine.Location = new Point(7, 3);
            addLine.Name = "addLine";
            addLine.Size = new Size(193, 23);
            addLine.TabIndex = 6;
            addLine.Text = "Добавить линию";
            addLine.UseVisualStyleBackColor = true;
            addLine.Click += addLine_Click;
            // 
            // changeLine
            // 
            changeLine.Location = new Point(7, 32);
            changeLine.Name = "changeLine";
            changeLine.Size = new Size(193, 23);
            changeLine.TabIndex = 7;
            changeLine.Text = "Изменить линию";
            changeLine.UseVisualStyleBackColor = true;
            changeLine.Click += changeLine_Click;
            // 
            // deleteLine
            // 
            deleteLine.Location = new Point(7, 61);
            deleteLine.Name = "deleteLine";
            deleteLine.Size = new Size(193, 23);
            deleteLine.TabIndex = 8;
            deleteLine.Text = "Удалить линию";
            deleteLine.UseVisualStyleBackColor = true;
            deleteLine.Click += deleteLine_Click;
            // 
            // addPolyLine
            // 
            addPolyLine.Location = new Point(11, 3);
            addPolyLine.Name = "addPolyLine";
            addPolyLine.Size = new Size(193, 23);
            addPolyLine.TabIndex = 9;
            addPolyLine.Text = "Добавить многоугольник";
            addPolyLine.UseVisualStyleBackColor = true;
            addPolyLine.Click += addPolyLine_Click;
            // 
            // changePolyLine
            // 
            changePolyLine.Location = new Point(11, 32);
            changePolyLine.Name = "changePolyLine";
            changePolyLine.Size = new Size(193, 23);
            changePolyLine.TabIndex = 10;
            changePolyLine.Text = "Изменить многоугольник";
            changePolyLine.UseVisualStyleBackColor = true;
            changePolyLine.Click += changePolyLine_Click;
            // 
            // deletePolyLine
            // 
            deletePolyLine.Location = new Point(11, 61);
            deletePolyLine.Name = "deletePolyLine";
            deletePolyLine.Size = new Size(193, 23);
            deletePolyLine.TabIndex = 11;
            deletePolyLine.Text = "Удалить многоугольник";
            deletePolyLine.UseVisualStyleBackColor = true;
            deletePolyLine.Click += deletePolyLine_Click;
            // 
            // panelPointsTools
            // 
            panelPointsTools.Controls.Add(addPoint);
            panelPointsTools.Controls.Add(changePoint);
            panelPointsTools.Controls.Add(DeletePoint);
            panelPointsTools.Location = new Point(12, 12);
            panelPointsTools.Name = "panelPointsTools";
            panelPointsTools.Size = new Size(200, 100);
            panelPointsTools.TabIndex = 12;
            // 
            // panelPolyLinesTools
            // 
            panelPolyLinesTools.Controls.Add(addPolyLine);
            panelPolyLinesTools.Controls.Add(changePolyLine);
            panelPolyLinesTools.Controls.Add(deletePolyLine);
            panelPolyLinesTools.Location = new Point(542, 18);
            panelPolyLinesTools.Name = "panelPolyLinesTools";
            panelPolyLinesTools.Size = new Size(216, 100);
            panelPolyLinesTools.TabIndex = 6;
            // 
            // panelLinesTools
            // 
            panelLinesTools.Controls.Add(addLine);
            panelLinesTools.Controls.Add(changeLine);
            panelLinesTools.Controls.Add(deleteLine);
            panelLinesTools.Location = new Point(299, 15);
            panelLinesTools.Name = "panelLinesTools";
            panelLinesTools.Size = new Size(209, 100);
            panelLinesTools.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPolyLinesTools);
            Controls.Add(panelLinesTools);
            Controls.Add(panelPointsTools);
            Controls.Add(listBoxPolyLines);
            Controls.Add(listBoxLines);
            Controls.Add(listBoxPoint);
            Name = "Main";
            Text = "Form1";
            panelPointsTools.ResumeLayout(false);
            panelPolyLinesTools.ResumeLayout(false);
            panelLinesTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPoint;
        private ListBox listBoxLines;
        private ListBox listBoxPolyLines;
        private Button addPoint;
        private Button changePoint;
        private Button DeletePoint;
        private Button addLine;
        private Button changeLine;
        private Button deleteLine;
        private Button addPolyLine;
        private Button changePolyLine;
        private Button deletePolyLine;
        private Panel panelPointsTools;
        private Panel panelPolyLinesTools;
        private Panel panelLinesTools;
    }
}
