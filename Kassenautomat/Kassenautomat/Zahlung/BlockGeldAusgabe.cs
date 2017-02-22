using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat.Zahlung
{
    static class BlockGeldAusgabe
    {
        public static void ZahleRestgeldAus(Banknote banknote)
        {
            Console.WriteLine("{0} Euroschein ausgeworfen", banknote.NennWert);
        }

        public static void ZahleRestgeldAus(Muenze muenze)
        {
            Console.WriteLine("{0} Euroschein ausgeworfen", muenze.NennWert);
        }

        public static void GebeNichtErkannteZahlungsmittelAus()
        {
            Console.WriteLine("Nicht Akzeptiert. Ausgeworfen !!!");
        }

    }
}
