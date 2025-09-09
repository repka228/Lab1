using WinFormsApp1.Classes.Point;
namespace WinFormsApp1.Classes.Line
{
    public abstract class AbstractLine
    {
        private ColoredPoint p1, p2;
        public ColoredPoint GetP1() => p1; 
        public ColoredPoint GetP2() => p2;
        public void RotateSecondPoint(double angleDegrees)
        {
            int dx = p2.GetX() - p1.GetX();
            int dy = p2.GetY() - p1.GetY();

            double angleRad = angleDegrees * Math.PI / 180.0;
            double cos = Math.Cos(angleRad);
            double sin = Math.Sin(angleRad);

            int newX = (int)(p1.GetX() + dx * cos - dy * sin);
            int newY = (int)(p1.GetY() + dx * sin + dy * cos);

            p2.SetX(newX);
            p2.SetY(newY);
        }
        public AbstractLine()
        {
            p1 = new ColoredPoint();
            p2 = new ColoredPoint();
        }
        public AbstractLine(ColoredPoint p1, ColoredPoint p2)
        {
            this.p1 = p1; this.p2 = p2;
        }
        public void SetP1(ColoredPoint p1) => this.p1 = p1;
        public void SetP2(ColoredPoint p2) => this.p2 = p2;
    };
}