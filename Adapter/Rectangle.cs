using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Rectangle : IShape
    {
        private readonly double _side_one;
        private readonly double _side_two;

        public Rectangle(double side1, double side2)
        {
            if (side1 * side2 <= 0 ) throw new ArgumentException();
            _side_one = side1;
            _side_two = side2;
        }
        public double GetArea()
        {
            return _side_one * _side_two;
        }

        public double GetPerimeter()
        {
            return 2 * (_side_one + _side_two);
        }
    }
}
