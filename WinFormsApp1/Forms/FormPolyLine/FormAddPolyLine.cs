using WinFormsApp1.Classes.Line;

namespace WinFormsApp1.Forms
{
    public partial class FormAddPolyLine : Form
    {
        public event EventHandler<PolyLine>? polyLineCreate;
        private List<LineWithColor> linesWithColor = [];
        public FormAddPolyLine() {
            InitializeComponent();
            ShowList();
        }
        public FormAddPolyLine(PolyLine polyLine)
        {
            InitializeComponent();
            linesWithColor = polyLine.GetLines();
            panelPolyLineColor.BackColor = linesWithColor[0].GetColor();
            ShowList();
        }

        private void buttonAddLine_Click(object sender, EventArgs e)
        {
            if (panelPolyLineColor.BackColor == SystemColors.Control) MessageBox.Show("Выберите цвет");
            else
            {
                FormAddLine lineForm = new();
                lineForm.lineWithColorCreate += (object? sender, LineWithColor e) => linesWithColor.Add(e);
                lineForm.panelColorLine.BackColor = panelPolyLineColor.BackColor;
                lineForm.buttonChooseColor.Enabled = false;
                if (lineForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Линия создана!");
                    ShowList();
                }
                else MessageBox.Show("Линия не создана!");

                lineForm.Dispose();
            }
        }
        private void buttonChangeLine_Click(object sender, EventArgs e)
        {
            if (listBoxLines.SelectedItem is LineWithColor selectedLine)
            {
                int index = linesWithColor.IndexOf(selectedLine);
                FormAddLine editLineForm = new();

                editLineForm.lineWithColorCreate += (s, newLine) => { linesWithColor[index] = newLine; };

                if (editLineForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Линия изменена!");
                    ShowList();
                }
            }
            else MessageBox.Show("Выберите линию для изменения!");
        }
        private void buttonDeleteLine_Click(object sender, EventArgs e)
        {
            if (listBoxLines.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Удалить выбранную линию?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    linesWithColor.RemoveAt(listBoxLines.SelectedIndex);
                    ShowList();
                    MessageBox.Show("Полилиния удалена!");
                }
            }
            else MessageBox.Show("Выберите полилинию для удаления!");
        }
        private void buttonChangeScale_Click(object sender, EventArgs e)
        {

        }
        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            using ColorDialog dlg = new ();
            if (dlg.ShowDialog() == DialogResult.OK) panelPolyLineColor.BackColor = dlg.Color;
            for (int i = 0; i < linesWithColor.Count; i++) linesWithColor[i].SetColor(dlg.Color);
        }

        private void ShowList()
        {
            if (listBoxLines == null) return;

            listBoxLines.DataSource = null;
            listBoxLines.DataSource = linesWithColor;
            listBoxLines.DisplayMember = "DisplayString";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            PolyLine newPolyLine = new(linesWithColor, panelPolyLineColor.BackColor);
            polyLineCreate?.Invoke(this, newPolyLine);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void buttonExit_Click(object sender, EventArgs e) => Close(); 
    }
}
