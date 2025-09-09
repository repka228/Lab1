namespace WinFormsApp1.Classes.Point
{
    public class ColoredPoint : AbstractPoint
    {
        private Color color { get; set; }
        public string DisplayString => $"x = {GetX()}, y = {GetY()},{GetColor()}";
        public ColoredPoint() => color = Color.Black;
        public ColoredPoint(Color color) => this.color = color;
        public ColoredPoint(Color color, int x, int y)
        {
            this.color = color;
            SetX(x);
            SetY(y);
        }
        public Color GetColor() => color;
        public void SetColor(Color color) => this.color = color;
    };
}