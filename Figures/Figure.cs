namespace Figures
{
    public abstract class Figure
    {
        private string _color;
        private bool _visible;
        protected int _x;
        protected int _y;
        public string Color { get { return _color; } set { _color = value; } }
        public bool Visible { get { return _visible; } }
        public Figure(string color, bool visible, int x, int y)
        {
            _color = color;
            _visible = visible;
            _x = x;
            _y = y;
        }
        public Figure(string color, bool visible)
        {
            _color = color;
            _visible = visible;
            _x = 0;
            _y = 0;
        }
        public virtual void MoveToXY(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public (int x, int y) GetXY()
        {
            return (_x, _y);
        }
        public override string ToString()
        {
            return $" type:{this.GetType()};  color:{_color};  visible:{_visible};  x y coordinates:{_x} {_y}; ";
        }
    }


}