using WinFormsApp1.Classes.Point;

namespace WinFormsApp1.Forms
{
    public partial class FormAddPoint : Form
    {
        public event EventHandler<ColoredPoint>? colorPointCreate;
        public FormAddPoint() => InitializeComponent();
        private void chooseColorButton_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new();
            if (dlg.ShowDialog() == DialogResult.OK) panelColorPoint.BackColor = dlg.Color;
        }
        private void buttonAddPoint_Click(object sender, EventArgs e)
        {
            ColoredPoint newColoredPoint = new (panelColorPoint.BackColor, (int)numericUpDown1.Value, (int)numericUpDown2.Value);
            colorPointCreate?.Invoke(this, newColoredPoint);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
