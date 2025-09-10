using WinFormsApp1.Classes.Line;

namespace WinFormsApp1.Forms.FormPolyLine
{
    public partial class FormScalePolyLine : Form
    {
        private PolyLine modifiedPolyLine;
        public event EventHandler<PolyLine>? polyLineScale;
        public FormScalePolyLine(PolyLine polyline)
        {
            InitializeComponent();
            modifiedPolyLine = polyline;
        }
        private void buttonScale_Click(object sender, EventArgs e)
        {
            modifiedPolyLine.Scale((double)numericUpDownScaleFactor.Value);
            polyLineScale?.Invoke(this, modifiedPolyLine);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonExit_Click(object sender, EventArgs e) => Close();
    }
}