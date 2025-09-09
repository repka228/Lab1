namespace Task
{
    public abstract class Line
    {
        private Point p1;
        private Point p2;
        public Point GetP1() { return p1; }
        public Point GetP2() { return p2; }

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
        public Line()
        {
            p1 = new ColoredPoint();
            p2 = new ColoredPoint();
        }
        public Line(Point p1, Point p2)
        {
            this.p1 = p1; this.p2 = p2;
        }
        public void SetP1(Point p1)
        {
            this.p1 = p1;
        }
        public void SetP2(Point p2)
        {
            this.p2 = p2;
        }
    };
}