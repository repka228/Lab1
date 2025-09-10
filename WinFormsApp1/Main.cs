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
        // Вызывает метод вызова формы создания/изменения
        private void addPoint_Click(object sender, EventArgs e) => ShowCreateForm(GeometryType.Point);
        // Передает в форму создания/изменения многоугольник
        private void changePoint_Click(object sender, EventArgs e)
        {
            if (listBoxPoint.SelectedItem is ColoredPoint selectedPoint)
            {
                int index = colorPoints.IndexOf(selectedPoint);
                FormAddPoint editPointForm = new FormAddPoint();

                editPointForm.colorPointCreate += (s, newPoint) => { colorPoints[index] = newPoint; };

                if (editPointForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Точка изменена!");
                    ShowList();
                }
            }
            else MessageBox.Show("Выберите точку для изменения!");
        }
        // Удаляет точку
        private void DeletePoint_Click(object sender, EventArgs e)
        {
            if (listBoxPoint.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Удалить выбранную точку?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    colorPoints.RemoveAt(listBoxPoint.SelectedIndex);
                    ShowList();
                    MessageBox.Show("Точка удалена!");
                }
            }
            else MessageBox.Show("Выберите точку для удаления!");
        }
        //Lines
        private void addLine_Click(object sender, EventArgs e) => ShowCreateForm(GeometryType.Line);
        // Передает в форму создания/изменения многоугольник
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
                    MessageBox.Show("Линия изменена!");
                    ShowList();
                }
            }
            else MessageBox.Show("Выберите линию для изменения!");
        }
        // Удаляет линию
        private void deleteLine_Click(object sender, EventArgs e)
        {
            if (listBoxLines.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Удалить выбранную линию?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    linesWithColor.RemoveAt(listBoxLines.SelectedIndex);
                    ShowList();
                    MessageBox.Show("Линия удалена!");
                }
            }
            else MessageBox.Show("Выберите линию для удаления!");
        }

        //PolyLines
        // Вызывает метод вызова формы создания/изменения
        private void addPolyLine_Click(object sender, EventArgs e) => ShowCreateForm(GeometryType.PolyLine);
        // Передает в форму создания/изменения многоугольник
        private void changePolyLine_Click(object sender, EventArgs e)
        {
            if (listBoxPolyLines.SelectedItem is PolyLine selectedPolyLine)
            {
                int index = polyLines.IndexOf(selectedPolyLine);
                FormAddPolyLine editPolyLineForm = new(selectedPolyLine);

                editPolyLineForm.polyLineCreate += (s, newLine) => { polyLines[index] = newLine; };

                if (editPolyLineForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Линия изменена!");
                    ShowList();
                }
            }
            else MessageBox.Show("Выберите линию для изменения!");
        }
        // Удаляет многоугольник
        private void deletePolyLine_Click(object sender, EventArgs e)
        {
            if (listBoxPolyLines.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Удалить выбранную полилинию?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    polyLines.RemoveAt(listBoxPolyLines.SelectedIndex);
                    ShowList();
                    MessageBox.Show("Полилиния удалена!");
                }
            }
            else MessageBox.Show("Выберите полилинию для удаления!");
        }

        // Общие методы
        // Вызывает метод обновления листов
        private void ShowList()
        {
            UpdateListBox(listBoxPoint, colorPoints);
            UpdateListBox(listBoxLines, linesWithColor);
            UpdateListBox(listBoxPolyLines, polyLines);
        }
        // Обновляет все листы
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
        // Вызывает формы создания/изменения фигур согласно типу
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

            if (result) MessageBox.Show($"{GetGeometryName(type)} создан!");
            else MessageBox.Show($"{GetGeometryName(type)} не создан!");
            ShowList();
        }

        // Общий обработчик для фигур
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
                    throw new ArgumentException($"Неизвестный тип фигуры: {geometryFigure.GetType()}");
            }
        }
        // Возвращает строковый вид типа фигуры
        private static string GetGeometryName(GeometryType type)
        {
            return type switch
            {
                GeometryType.Point => "Точка",
                GeometryType.Line => "Линия",
                GeometryType.PolyLine => "Полилиния",
                _ => "Объект"
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
                    MessageBox.Show("Точка смещена!");
                    ShowList();
                }
            }
            else MessageBox.Show("Выберите линию для смещения!");
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
                    MessageBox.Show("Точка смещена!");
                    ShowList();
                }
            }
            else MessageBox.Show("Выберите линию для смещения!");
        }
    }
}