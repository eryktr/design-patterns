using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SquareAdapter : IShape
    {
        private StrangeSquare _strangeSquare;
        private readonly double _side;

        public SquareAdapter(StrangeSquare strangeSquare)
        {
            _strangeSquare = strangeSquare;
            _side = strangeSquare.GetDiagonal() / Math.Sqrt(2);
        }


        public double GetArea()
        {
            return _side * _side;
        }

        public double GetPerimeter()
        {
            return 4 * _side;
        }
    }
}
