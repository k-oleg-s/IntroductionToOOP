namespace Figures
{
    public abstract class Point : Figure, ISetCoordinates, IBorderLine
    {
        public Point(string color, bool visible, int x, int y) : base(color, visible, x, y)
        {
        }

        private int _lineWidth;
        private string _lineStyle;
        public int LineWidth { get => _lineWidth; set { if (value >= 0) _lineWidth = value; } }
        public string LineStyle { get => _lineStyle; set => _lineStyle = value; }

        public abstract float GetArea();

        public void SetX(int x)
        {
            _x = x;
        }

        public void SetY(int y)
        {
            _y = y;
        }
    }


}