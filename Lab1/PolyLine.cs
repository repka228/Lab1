using System.Drawing;

namespace Task
{
    public class PolyLine
    {
        private ColoredPoint[] points; 
        private Color lineColor;

        public PolyLine()
        {
            points = [];
            lineColor = Color.Black;
        }

        public PolyLine(ColoredPoint[] points)
        {
            this.points = points;
            lineColor = Color.Black;
        }

        public PolyLine(int vertexCount)
        {
            points = new ColoredPoint[vertexCount];
            lineColor = Color.Black;
        }

        public PolyLine(ColoredPoint[] points, Color color)
        {
            this.points = points;
            this.lineColor = color;
        }

        public void AddPoint(ColoredPoint point)
        {
            Array.Resize(ref points, points.Length + 1);
            points[points.Length - 1] = point;
        }

        public ColoredPoint[] GetPoints() { return points; }

        public void SetPoints(ColoredPoint[] points) { this.points = points; }

        public Color GetColor() { return lineColor; }

        public void SetColor(Color color) { this.lineColor = color; }

        public void Scale(double scaleFactor)
        {
            if (points.Length == 0) return;

            int centerX = 0;
            int centerY = 0;

            foreach (var point in points)
            {
                centerX += point.GetX();
                centerY += point.GetY();
            }

            centerX /= points.Length;
            centerY /= points.Length;

            foreach (var point in points)
            {
                int dx = point.GetX() - centerX;
                int dy = point.GetY() - centerY;

                point.SetX(centerX + (int)(dx * scaleFactor));
                point.SetY(centerY + (int)(dy * scaleFactor));
            }
        }

        public void Scale(double scaleFactor, ColoredPoint centerPoint)
        {
            foreach (var point in points)
            {
                int dx = point.GetX() - centerPoint.GetX();
                int dy = point.GetY() - centerPoint.GetY();

                point.SetX(centerPoint.GetX() + (int)(dx * scaleFactor));
                point.SetY(centerPoint.GetY() + (int)(dy * scaleFactor));
            }
        }

        public void ScaleSimple(double scaleFactor)
        {
            foreach (var point in points)
            {
                point.SetX((int)(point.GetX() * scaleFactor));
                point.SetY((int)(point.GetY() * scaleFactor));
            }
        }

        public double GetPerimeter()
        {
            if (points.Length < 2) return 0;

            double perimeter = 0;
            for (int i = 0; i < points.Length; i++)
            {
                ColoredPoint current = points[i];
                ColoredPoint next = points[(i + 1) % points.Length];

                int dx = next.GetX() - current.GetX();
                int dy = next.GetY() - current.GetY();
                perimeter += Math.Sqrt(dx * dx + dy * dy);
            }

            return perimeter;
        }

        public bool IsClosed()
        {
            return points.Length > 2 &&
                   points[0].GetX() == points[points.Length - 1].GetX() &&
                   points[0].GetY() == points[points.Length - 1].GetY();
        }

        public void ClosePolygon()
        {
            if (points.Length > 2 && !IsClosed())
            {
                Array.Resize(ref points, points.Length + 1);
                points[points.Length - 1] = new ColoredPoint(
                    points[0].GetColor(),
                    points[0].GetX(),
                    points[0].GetY()
                );
            }
        }

        public int GetVertexCount()
        {
            return points.Length;
        }

        public void Clear()
        {
            points = [];
        }

        public override string ToString()
        {
            return $"PolyLine with {points.Length} vertices, Color: {lineColor.Name}";
        }
    }
}