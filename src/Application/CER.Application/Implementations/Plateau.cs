using CER.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER.Application.Implementations
{
    public class Plateau : IPlateau
    {
        private int _pointX, _pointY;

        public Plateau(int pointX, int pointY)
        {
            _pointX = pointX;
            _pointY = pointY;
        }

        public int PointX
        {
            get { return _pointX; }
            set { _pointX = value; }
        }
        public int PointY
        {
            get { return _pointY; }
            set { _pointY = value; }
        }

    }
}
