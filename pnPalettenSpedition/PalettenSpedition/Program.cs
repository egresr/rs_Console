using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Artikel> listArtikels = test_listArtikelsGenerator.Erzeuge();
            ArtikelBestand.Ausgeben(listArtikels);
            Sendung sendung = new Sendung(3, listArtikels[2], new Palette());



            Console.ReadLine();
        }
    }
}
