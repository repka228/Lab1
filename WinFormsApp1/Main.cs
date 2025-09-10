using WinFormsApp1.Classes;
using WinFormsApp1.Classes.Line;
using WinFormsApp1.Classes.Point;
using WinFormsApp1.Forms;
using WinFormsApp1.Forms.FormPolyLine;

namespace WinFormsApp1
{
    public partial class Main : Form
    {
        private static readonly List<ColoredPoint> colorPoints = [];
        private static readonly List<PolyLine> polyLines = [];
        private static readonly List<LineWithColor> linesWithColor = [];
        public Main() => InitializeComponent();

        // Points
        // �������� ����� ������ ����� ��������/���������
        private void addPoint_Click(object sender, EventArgs e) => ShowCreateForm(GeometryType.Point);
        // �������� � ����� ��������/��������� �������������
        private void changePoint_Click(object sender, EventArgs e)
        {
            if (listBoxPoint.SelectedItem is ColoredPoint selectedPoint)
            {
                int index = colorPoints.IndexOf(selectedPoint);
                FormAddPoint editPointForm = new FormAddPoint();

                editPointForm.colorPointCreate += (s, newPoint) => { colorPoints[index] = newPoint; };

                if (editPointForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("����� ��������!");
                    ShowList();
                }
            }
            else MessageBox.Show("�������� ����� ��� ���������!");
        }
        // ������� �����
        private void DeletePoint_Click(object sender, EventArgs e)
        {
            if (listBoxPoint.SelectedIndex >= 0)
            {
                if (MessageBox.Show("������� ��������� �����?", "�������������", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    colorPoints.RemoveAt(listBoxPoint.SelectedIndex);
                    ShowList();
                    MessageBox.Show("����� �������!");
                }
            }
            else MessageBox.Show("�������� ����� ��� ��������!");
        }
        //Lines
        private void addLine_Click(object sender, EventArgs e) => ShowCreateForm(GeometryType.Line);
        // �������� � ����� ��������/��������� �������������
        private void changeLine_Click(object sender, EventArgs e)
        {
            if (listBoxLines.SelectedItem is LineWithColor selectedLine)
            {
                int index = linesWithColor.IndexOf(selectedLine);
                FormAddLine editLineForm = new();

                editLineForm.lineWithColorCreate += (s, newLine) =>
                {
                    linesWithColor[index] = newLine;
                };

                if (editLineForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("����� ��������!");
                    ShowList();
                }
            }
            else MessageBox.Show("�������� ����� ��� ���������!");
        }
        // ������� �����
        private void deleteLine_Click(object sender, EventArgs e)
        {
            if (listBoxLines.SelectedIndex >= 0)
            {
                if (MessageBox.Show("������� ��������� �����?", "�������������", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    linesWithColor.RemoveAt(listBoxLines.SelectedIndex);
                    ShowList();
                    MessageBox.Show("����� �������!");
                }
            }
            else MessageBox.Show("�������� ����� ��� ��������!");
        }

        //PolyLines
        // �������� ����� ������ ����� ��������/���������
        private void addPolyLine_Click(object sender, EventArgs e) => ShowCreateForm(GeometryType.PolyLine);
        // �������� � ����� ��������/��������� �������������
        private void changePolyLine_Click(object sender, EventArgs e)
        {
            if (listBoxPolyLines.SelectedItem is PolyLine selectedPolyLine)
            {
                int index = polyLines.IndexOf(selectedPolyLine);
                FormAddPolyLine editPolyLineForm = new(selectedPolyLine);

                editPolyLineForm.polyLineCreate += (s, newLine) => { polyLines[index] = newLine; };

                if (editPolyLineForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("����� ��������!");
                    ShowList();
                }
            }
            else MessageBox.Show("�������� ����� ��� ���������!");
        }
        // ������� �������������
        private void deletePolyLine_Click(object sender, EventArgs e)
        {
            if (listBoxPolyLines.SelectedIndex >= 0)
            {
                if (MessageBox.Show("������� ��������� ���������?", "�������������", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    polyLines.RemoveAt(listBoxPolyLines.SelectedIndex);
                    ShowList();
                    MessageBox.Show("��������� �������!");
                }
            }
            else MessageBox.Show("�������� ��������� ��� ��������!");
        }

        // ����� ������
        // �������� ����� ���������� ������
        private void ShowList()
        {
            UpdateListBox(listBoxPoint, colorPoints);
            UpdateListBox(listBoxLines, linesWithColor);
            UpdateListBox(listBoxPolyLines, polyLines);
        }
        // ��������� ��� �����
        private static void UpdateListBox<T>(ListBox listBox, List<T> dataSource) where T : class
        {
            if (listBox == null) return;

            int selectedIndex = listBox.SelectedIndex;
            var currentItem = selectedIndex >= 0 ? listBox.SelectedItem : null;

            listBox.DataSource = null;
            listBox.DataSource = dataSource;
            listBox.DisplayMember = "DisplayString";

            if (currentItem != null && dataSource.Contains(currentItem as T)) listBox.SelectedItem = currentItem;
            else if (selectedIndex >= 0 && selectedIndex < listBox.Items.Count) listBox.SelectedIndex = selectedIndex;
            else if (listBox.Items.Count > 0) listBox.SelectedIndex = 0;
        }
        // �������� ����� ��������/��������� ����� �������� ����
        private void ShowCreateForm(GeometryType type)
        {
            Form? createForm = null;
            bool result = false;

            switch (type)
            {
                case GeometryType.Point:
                    var pointForm = new FormAddPoint();
                    pointForm.colorPointCreate += HandleGeometryCreation;
                    createForm = pointForm;
                    result = pointForm.ShowDialog() == DialogResult.OK;
                    break;

                case GeometryType.Line:
                    var lineForm = new FormAddLine();
                    lineForm.lineWithColorCreate += HandleGeometryCreation;
                    createForm = lineForm;
                    result = lineForm.ShowDialog() == DialogResult.OK;
                    break;

                case GeometryType.PolyLine:
                    var polyLineForm = new FormAddPolyLine();
                    polyLineForm.polyLineCreate += HandleGeometryCreation;
                    createForm = polyLineForm;
                    result = polyLineForm.ShowDialog() == DialogResult.OK;
                    break;
            }

            createForm?.Dispose();

            if (result) MessageBox.Show($"{GetGeometryName(type)} ������!");
            else MessageBox.Show($"{GetGeometryName(type)} �� ������!");
            ShowList();
        }

        // ����� ���������� ��� �����
        private void HandleGeometryCreation(object? sender, object geometryFigure)
        {
            switch (geometryFigure)
            {
                case ColoredPoint point:
                    colorPoints.Add(point);
                    break;
                case LineWithColor line:
                    linesWithColor.Add(line);
                    break;
                case PolyLine polyLine:
                    polyLines.Add(polyLine);
                    break;
                default:
                    throw new ArgumentException($"����������� ��� ������: {geometryFigure.GetType()}");
            }
        }
        // ���������� ��������� ��� ���� ������
        private static string GetGeometryName(GeometryType type)
        {
            return type switch
            {
                GeometryType.Point => "�����",
                GeometryType.Line => "�����",
                GeometryType.PolyLine => "���������",
                _ => "������"
            };
        }

        private void buttonOffset_Click(object sender, EventArgs e)
        {
            if (listBoxLines.SelectedItem is LineWithColor selectedLine)
            {
                int index = linesWithColor.IndexOf(selectedLine);
                FormOffsetLine editLineForm = new(selectedLine);

                editLineForm.LineWithColorOffset += (s, newLine) =>
                {
                    linesWithColor[index] = newLine;
                };

                if (editLineForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("����� �������!");
                    ShowList();
                }
            }
            else MessageBox.Show("�������� ����� ��� ��������!");
        }
        private void buttonScale_Click(object sender, EventArgs e)
        {
            if (listBoxPolyLines.SelectedItem is PolyLine selectedPolyLine)
            {
                int index = polyLines.IndexOf(selectedPolyLine);
                FormScalePolyLine editLineForm = new(selectedPolyLine);
                editLineForm.polyLineScale += (s, polyLine) =>
                {
                    polyLines[index] = polyLine ;
                };
                if (editLineForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("����� �������!");
                    ShowList();
                }
            }
            else MessageBox.Show("�������� ����� ��� ��������!");
        }
    }
}