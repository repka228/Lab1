using WinFormsApp1.Classes.Line;

namespace WinFormsApp1.Forms
{
    public partial class FormOffsetLine : Form
    {
        private LineWithColor modifiedLine;
        public event EventHandler<LineWithColor>? LineWithColorOffset;
        public FormOffsetLine(LineWithColor line)
        {
            InitializeComponent();
            modifiedLine = new LineWithColor(line.GetColor(), line.GetP1(), line.GetP2());
        }
        private void buttonOffsetByAngle_Click(object sender, EventArgs e)
        {
            modifiedLine.OffsetSecondPointByAngle((double)numericUpDownDegrees.Value, (double)numericUpDownDistance.Value);
            LineWithColorOffset?.Invoke(this, modifiedLine);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonExit_Click(object sender, EventArgs e) => Close();
    }
}