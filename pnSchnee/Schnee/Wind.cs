using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnee
{
    class Wind
    {
        int geschwindigkeit; //Pixel pro Takt
        public int Geschwindigkeit{get;}

        public Wind(int geschwindigkeit)
        {
            this.geschwindigkeit = geschwindigkeit;
        }
    }
}
