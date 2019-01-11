using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Adapter
{
    class StrangeSquare
    {
        private readonly double _diagonal;

        public StrangeSquare(double diagonal)
        {
            if (diagonal <= 0) throw new ArgumentException();
            _diagonal = diagonal;
        }

        public double GetDiagonal()
        {
            return _diagonal;
        }
    }
}
