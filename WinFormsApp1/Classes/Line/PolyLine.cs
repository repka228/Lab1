
namespace WinFormsApp1.Classes.Line
{
    public class PolyLine
    {
        private List<LineWithColor> lines = []; 
        private Color lineColor;
        public string DisplayString => $"кол-во линий - {lines.Count}, цвет - {GetColor()}";
        public PolyLine()
        {
            lines = [];
            lineColor = Color.Black;
        }
        public PolyLine(List<LineWithColor> lines)
        {
            this.lines = lines;
            lineColor = Color.Black;
        }
        public PolyLine(int vertexCount)
        {
            for(int i =0; i < vertexCount; i++) lines.Add(new LineWithColor());
            lineColor = Color.Black;
        }
        public PolyLine(List<LineWithColor> lines, Color color)
        {
            this.lines = lines;
            lineColor = color;
        }
        public Color GetColor() => lineColor;
        public List<LineWithColor> GetLines() => lines;
        public void SetColor(Color color) => lineColor = color;
    }
}