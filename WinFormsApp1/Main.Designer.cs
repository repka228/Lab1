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
            buttonAddPoint = new Button();
            buttonChangePoint = new Button();
            buttonDeletePoint = new Button();
            buttonAddLine = new Button();
            buttonChangeLine = new Button();
            deleteLine = new Button();
            addPolyLine = new Button();
            changePolyLine = new Button();
            deletePolyLine = new Button();
            panelPointsTools = new Panel();
            panelPolyLinesTools = new Panel();
            buttonScalePolyLine = new Button();
            buttonPanelLinesTools = new Panel();
            buttonOffsetLine = new Button();
            panelPointsTools.SuspendLayout();
            panelPolyLinesTools.SuspendLayout();
            buttonPanelLinesTools.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxPoint
            // 
            listBoxPoint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxPoint.FormattingEnabled = true;
            listBoxPoint.ItemHeight = 15;
            listBoxPoint.Location = new Point(12, 118);
            listBoxPoint.Name = "listBoxPoint";
            listBoxPoint.Size = new Size(193, 319);
            listBoxPoint.TabIndex = 0;
            // 
            // listBoxLines
            // 
            listBoxLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxLines.FormattingEnabled = true;
            listBoxLines.ItemHeight = 15;
            listBoxLines.Location = new Point(218, 135);
            listBoxLines.Name = "listBoxLines";
            listBoxLines.Size = new Size(235, 304);
            listBoxLines.TabIndex = 1;
            // 
            // listBoxPolyLines
            // 
            listBoxPolyLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            listBoxPolyLines.FormattingEnabled = true;
            listBoxPolyLines.ItemHeight = 15;
            listBoxPolyLines.Location = new Point(459, 135);
            listBoxPolyLines.Name = "listBoxPolyLines";
            listBoxPolyLines.Size = new Size(299, 304);
            listBoxPolyLines.TabIndex = 2;
            // 
            // buttonAddPoint
            // 
            buttonAddPoint.Anchor = AnchorStyles.Top;
            buttonAddPoint.Location = new Point(4, 3);
            buttonAddPoint.Name = "buttonAddPoint";
            buttonAddPoint.Size = new Size(193, 23);
            buttonAddPoint.TabIndex = 3;
            buttonAddPoint.Text = "Добавить точку";
            buttonAddPoint.UseVisualStyleBackColor = true;
            buttonAddPoint.Click += addPoint_Click;
            // 
            // buttonChangePoint
            // 
            buttonChangePoint.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonChangePoint.Location = new Point(4, 32);
            buttonChangePoint.Name = "buttonChangePoint";
            buttonChangePoint.Size = new Size(193, 23);
            buttonChangePoint.TabIndex = 4;
            buttonChangePoint.Text = "Изменить точку";
            buttonChangePoint.UseVisualStyleBackColor = true;
            buttonChangePoint.Click += changePoint_Click;
            // 
            // buttonDeletePoint
            // 
            buttonDeletePoint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDeletePoint.Location = new Point(4, 61);
            buttonDeletePoint.Name = "buttonDeletePoint";
            buttonDeletePoint.Size = new Size(193, 23);
            buttonDeletePoint.TabIndex = 5;
            buttonDeletePoint.Text = "Удалить точку";
            buttonDeletePoint.UseVisualStyleBackColor = true;
            buttonDeletePoint.Click += DeletePoint_Click;
            // 
            // buttonAddLine
            // 
            buttonAddLine.Anchor = AnchorStyles.Top;
            buttonAddLine.Location = new Point(7, 3);
            buttonAddLine.Name = "buttonAddLine";
            buttonAddLine.Size = new Size(225, 23);
            buttonAddLine.TabIndex = 6;
            buttonAddLine.Text = "Добавить линию";
            buttonAddLine.UseVisualStyleBackColor = true;
            buttonAddLine.Click += addLine_Click;
            // 
            // buttonChangeLine
            // 
            buttonChangeLine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonChangeLine.Location = new Point(7, 32);
            buttonChangeLine.Name = "buttonChangeLine";
            buttonChangeLine.Size = new Size(225, 23);
            buttonChangeLine.TabIndex = 7;
            buttonChangeLine.Text = "Изменить линию";
            buttonChangeLine.UseVisualStyleBackColor = true;
            buttonChangeLine.Click += changeLine_Click;
            // 
            // deleteLine
            // 
            deleteLine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deleteLine.Location = new Point(7, 61);
            deleteLine.Name = "deleteLine";
            deleteLine.Size = new Size(225, 23);
            deleteLine.TabIndex = 8;
            deleteLine.Text = "Удалить линию";
            deleteLine.UseVisualStyleBackColor = true;
            deleteLine.Click += deleteLine_Click;
            // 
            // addPolyLine
            // 
            addPolyLine.Anchor = AnchorStyles.Top;
            addPolyLine.Location = new Point(11, 3);
            addPolyLine.Name = "addPolyLine";
            addPolyLine.Size = new Size(285, 23);
            addPolyLine.TabIndex = 9;
            addPolyLine.Text = "Добавить многоугольник";
            addPolyLine.UseVisualStyleBackColor = true;
            addPolyLine.Click += addPolyLine_Click;
            // 
            // changePolyLine
            // 
            changePolyLine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            changePolyLine.Location = new Point(11, 32);
            changePolyLine.Name = "changePolyLine";
            changePolyLine.Size = new Size(285, 23);
            changePolyLine.TabIndex = 10;
            changePolyLine.Text = "Изменить многоугольник";
            changePolyLine.UseVisualStyleBackColor = true;
            changePolyLine.Click += changePolyLine_Click;
            // 
            // deletePolyLine
            // 
            deletePolyLine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deletePolyLine.Location = new Point(11, 61);
            deletePolyLine.Name = "deletePolyLine";
            deletePolyLine.Size = new Size(285, 23);
            deletePolyLine.TabIndex = 11;
            deletePolyLine.Text = "Удалить многоугольник";
            deletePolyLine.UseVisualStyleBackColor = true;
            deletePolyLine.Click += deletePolyLine_Click;
            // 
            // panelPointsTools
            // 
            panelPointsTools.Controls.Add(buttonAddPoint);
            panelPointsTools.Controls.Add(buttonChangePoint);
            panelPointsTools.Controls.Add(buttonDeletePoint);
            panelPointsTools.Location = new Point(12, 12);
            panelPointsTools.Name = "panelPointsTools";
            panelPointsTools.Size = new Size(200, 90);
            panelPointsTools.TabIndex = 12;
            // 
            // panelPolyLinesTools
            // 
            panelPolyLinesTools.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelPolyLinesTools.Controls.Add(buttonScalePolyLine);
            panelPolyLinesTools.Controls.Add(addPolyLine);
            panelPolyLinesTools.Controls.Add(changePolyLine);
            panelPolyLinesTools.Controls.Add(deletePolyLine);
            panelPolyLinesTools.Location = new Point(459, 12);
            panelPolyLinesTools.Name = "panelPolyLinesTools";
            panelPolyLinesTools.Size = new Size(299, 111);
            panelPolyLinesTools.TabIndex = 6;
            // 
            // buttonScalePolyLine
            // 
            buttonScalePolyLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonScalePolyLine.Location = new Point(11, 85);
            buttonScalePolyLine.Name = "buttonScalePolyLine";
            buttonScalePolyLine.Size = new Size(285, 23);
            buttonScalePolyLine.TabIndex = 12;
            buttonScalePolyLine.Text = "Масштабировать";
            buttonScalePolyLine.UseVisualStyleBackColor = true;
            buttonScalePolyLine.Click += buttonScale_Click;
            // 
            // buttonPanelLinesTools
            // 
            buttonPanelLinesTools.Anchor = AnchorStyles.Top;
            buttonPanelLinesTools.Controls.Add(buttonOffsetLine);
            buttonPanelLinesTools.Controls.Add(buttonAddLine);
            buttonPanelLinesTools.Controls.Add(buttonChangeLine);
            buttonPanelLinesTools.Controls.Add(deleteLine);
            buttonPanelLinesTools.Location = new Point(218, 12);
            buttonPanelLinesTools.Name = "buttonPanelLinesTools";
            buttonPanelLinesTools.Size = new Size(235, 115);
            buttonPanelLinesTools.TabIndex = 0;
            // 
            // buttonOffsetLine
            // 
            buttonOffsetLine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonOffsetLine.Location = new Point(7, 89);
            buttonOffsetLine.Name = "buttonOffsetLine";
            buttonOffsetLine.Size = new Size(225, 23);
            buttonOffsetLine.TabIndex = 9;
            buttonOffsetLine.Text = "Сместить 2-ю точку";
            buttonOffsetLine.UseVisualStyleBackColor = true;
            buttonOffsetLine.Click += buttonOffset_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPolyLinesTools);
            Controls.Add(buttonPanelLinesTools);
            Controls.Add(panelPointsTools);
            Controls.Add(listBoxPolyLines);
            Controls.Add(listBoxLines);
            Controls.Add(listBoxPoint);
            Name = "Main";
            Text = "Form1";
            panelPointsTools.ResumeLayout(false);
            panelPolyLinesTools.ResumeLayout(false);
            buttonPanelLinesTools.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPoint;
        private ListBox listBoxLines;
        private ListBox listBoxPolyLines;
        private Button buttonAddPoint;
        private Button buttonChangePoint;
        private Button buttonDeletePoint;
        private Button buttonAddLine;
        private Button buttonChangeLine;
        private Button deleteLine;
        private Button addPolyLine;
        private Button changePolyLine;
        private Button deletePolyLine;
        private Panel panelPointsTools;
        private Panel panelPolyLinesTools;
        private Panel buttonPanelLinesTools;
        private Button buttonScalePolyLine;
        private Button buttonOffsetLine;
    }
}
