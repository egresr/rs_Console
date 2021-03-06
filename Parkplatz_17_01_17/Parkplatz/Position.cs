﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class Position
    {
        int koordinateX;
        int koordinateY;

        public int KoordinateX { get { return koordinateX; } set { koordinateX = value; } }
        public int KoordinateY { get { return koordinateY; } set { koordinateY = value; } }


        public Position(int koordinateX, int koordinateY)
        {
            this.koordinateX = koordinateX;
            this.koordinateY = koordinateY;
        }
        public Position(Position position)
        {
            koordinateX = position.KoordinateX;
            koordinateY = position.KoordinateY;
        }
    }
}
