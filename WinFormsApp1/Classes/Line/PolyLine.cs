using WinFormsApp1.Classes.Point;

namespace WinFormsApp1.Classes.Line
{
    public class PolyLine
    {
        private readonly List<LineWithColor> lines = []; 
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
        public void Scale(double scaleFactor)
        {
            if (lines.Count == 0) return;

            ColoredPoint referencePoint = lines[0].GetP1();
            int refX = referencePoint.GetX();
            int refY = referencePoint.GetY();

            foreach (var line in lines)
            {
                ScalePoint(line.GetP1(), refX, refY, scaleFactor);
                ScalePoint(line.GetP2(), refX, refY, scaleFactor);
            }
        }
        public void Scale(double scaleFactor, int referenceX, int referenceY)
        {
            foreach (var line in lines)
            {
                ScalePoint(line.GetP1(), referenceX, referenceY, scaleFactor);
                ScalePoint(line.GetP2(), referenceX, referenceY, scaleFactor);
            }
        }
        private void ScalePoint(ColoredPoint point, int refX, int refY, double scaleFactor)
        {
            int offsetX = point.GetX() - refX;
            int offsetY = point.GetY() - refY;

            int scaledOffsetX = (int)(offsetX * scaleFactor);
            int scaledOffsetY = (int)(offsetY * scaleFactor);

            point.SetX(refX + scaledOffsetX);
            point.SetY(refY + scaledOffsetY);
        }
    }
}