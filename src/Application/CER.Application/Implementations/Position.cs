using CER.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CER.Application.Implementations
{
    public class Position : IPosition
    {
        private int _x, _y;

        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }


        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
