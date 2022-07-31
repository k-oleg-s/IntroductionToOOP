namespace Figures
{
    public class Rectangle : Point
    {
        private int _w;
        private int _h;
        public Rectangle(string color, bool visible, int x, int y, int w, int h) : base(color, visible, x, y)
        {
            _w = w;
            _h = h;
        }
        public override float GetArea()
        {
            return _h * _w;
        }
    }


}