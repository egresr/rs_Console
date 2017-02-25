using KassenAutomat_M005.ModulBezahlVerfahren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenAutomat_M005
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double parkKosten = 123.45;
            BezahlVerfahren bezahlVerfahren = new BezahlVerfahren(parkKosten);


        }
    }
}
