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
            Console.ReadLine();
            ArtikelProPalette sendung = new ArtikelProPalette(listArtikels);
            List<ArtikelProPalette> artikelProPalette = sendung.PackeArtikelAufPalette();



            Console.ReadLine();
        }
    }
}
