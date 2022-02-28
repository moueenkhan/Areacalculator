namespace CalculateArea
{
    public class Rectangle : Shape
    {
        private readonly float _length;
        private readonly float _breadth;

        public Rectangle(float length, float breadth)
        {
            this._length = length;
            this._breadth = breadth;
        }
        public float GetArea()
        {
            return _length * _breadth;
        }
    }
}
