using WinFormsApp1.Classes.Point;

namespace WinFormsApp1.Classes.Line
{
    public class LineWithColor : AbstractLine
    {
        private Color color;
        public Color GetColor() => color; 
        public void SetColor(Color color) => this.color = color; 
        public string DisplayString => $"x1 = {GetP1().GetX()}, y1 = {GetP1().GetY()}, " + $"x2 = {GetP2().GetX()}, y2 = {GetP2().GetY()}, " + $"цвет - {GetColor().Name}";
        public LineWithColor() => color = Color.Black;
        public LineWithColor(Color color) { 
            this.color = color; 
            GetP1().SetColor(color);
            GetP2().SetColor(color);
        }
        public LineWithColor(Color color, ColoredPoint p1, ColoredPoint p2)
        {
            this.color = color;
            SetP1(p1);
            SetP2(p2);
        }
    }
};