using System;

namespace CalculateArea
{
    public class Circle : Shape
    {
        private readonly float _radius;
        public Circle(float radius)
        {
            this._radius = radius;
        }
        public float GetArea()
        {
            return (float)Math.PI * _radius * _radius;
        }
    }
}
