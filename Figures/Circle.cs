namespace Figures
{
    public class Circle : Point
    {
        private int _radius;
        public Circle(string color, bool visible, int x, int y, int radius) : base(color, visible, x, y)
        {
            _radius = radius;
        }
        public override float GetArea()
        {
            return (float)Math.PI * _radius * _radius;
        }
    }


}