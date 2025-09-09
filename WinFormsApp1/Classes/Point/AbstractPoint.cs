namespace WinFormsApp1.Classes.Point
{
    public abstract class AbstractPoint
    {
        private int x, y;
        public AbstractPoint()
        {
            x = 0; y = 0;
        }
        public AbstractPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public int GetX() => x;
        public int GetY() => y;
        public void SetX(int x) => this.x = x;
        public void SetY(int y) => this.y = y;
    };
}