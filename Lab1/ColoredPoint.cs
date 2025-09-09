using System.Drawing;
namespace Task
{
    public class ColoredPoint : Point
    {
        private Color color { get; set; }
        public ColoredPoint()
        {
            color = Color.Black;
        }
        public ColoredPoint(Color color)
        {
            this.color = color;
        }
        public ColoredPoint(Color color, int x, int y)
        {
            this.color = color;
            SetX(x);
            SetY(y);
        }
        public Color GetColor()
        {
            return color;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public override string ToString()
        {
            return $"({GetX}, {GetY}, " + color.ToString()+ ")";
        }
    };
}