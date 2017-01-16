using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Position
    {
        int koordinateX;
        int koordinateY;

        public int KoordinateX { get { return koordinateX; } set { } }
        public int KoordinateY { get { return koordinateY; } set { } }

        public Position(int koordinateX, int koordinateY)
        {
            this.koordinateX = koordinateX;
            this.koordinateY = koordinateY;
        }
    }
}
