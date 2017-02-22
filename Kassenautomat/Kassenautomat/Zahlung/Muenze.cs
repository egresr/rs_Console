using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat.Zahlung
{
    class Muenze
    {
        public int NennWert { get; private set; }

        public Muenze(int nennWert)
        {
            NennWert = nennWert;
        }
    }
}
