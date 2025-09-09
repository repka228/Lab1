using System.Drawing;
namespace Task
{
    public class LineWithColor : Line
    {
        private Color color;
        public Color GetColor() { return color; }
        public void SetColor(Color color) { this.color = color; }
        public LineWithColor()
        {
            color = Color.Black;
        }
        public LineWithColor(Color color)
        {
            this.color = color;
        }
        public LineWithColor(Color color, Point p1, Point p2)
        {
            this.color = color;
            SetP1(p1);
            SetP2(p2);
        }
    };
}