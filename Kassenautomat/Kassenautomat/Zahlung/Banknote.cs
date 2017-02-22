using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat.Zahlung
{
    class Banknote
    {
        public int NennWert { get; private set; }

        public Banknote(int nennWert)
        {
            NennWert = nennWert;
        }
    }
}
