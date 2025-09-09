using WinFormsApp1.Classes.Line;
using WinFormsApp1.Classes.Point;
namespace WinFormsApp1.Forms
{
    public partial class FormAddLine : Form
    {
        public event EventHandler<LineWithColor>? lineWithColorCreate;
        public FormAddLine() => InitializeComponent();

        private void buttonExit_Click(object sender, EventArgs e) => Close();

        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) panelColorLine.BackColor = dlg.Color;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            LineWithColor newLineWithColor = new(panelColorLine.BackColor, new ColoredPoint(panelColorLine.BackColor, (int)numericUpDownX1.Value, (int)numericUpDownY1.Value), new ColoredPoint(panelColorLine.BackColor, (int)numericUpDownX2.Value, (int)numericUpDownY2.Value));
            lineWithColorCreate?.Invoke(this, newLineWithColor);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
