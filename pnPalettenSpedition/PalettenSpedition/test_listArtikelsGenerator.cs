using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{
    //
    //es wird eine Liste mit 10 Artikel generiert
    //

    class test_listArtikelsGenerator
    {
        public static List<Artikel> Erzeuge()
        {
            int id = 0;
            string bezeichnung;
            Einheit einheit = Einheit.Packung;
            double maxGewichtProEinheit = 100.0;
            double maxBreite = 1000.0;
            double maxLaenge = 1000.0;
            double maxHohe = 1000.0;

            Random random = new Random();
            List<Artikel> listArtikels = new List<Artikel>();
            int maxArtikelAnzahl = 10;

            for (int i = 0; i < maxArtikelAnzahl; i++)
            {
                id++;
                bezeichnung = "Bezeichnung Artikel Nr_" + id + "_BSP";
                double gewichtProEinheit = Convert.ToInt32( 10 + (maxGewichtProEinheit - 10) * random.NextDouble());
                int breite = Convert.ToInt32( 100 + (maxBreite - 100) * random.NextDouble());
                double laenge = Convert.ToInt32(100 + (maxLaenge - 100) * random.NextDouble());
                double hohe = Convert.ToInt32(100 + (maxHohe - 100) * random.NextDouble());

                listArtikels.Add(new Artikel(id, bezeichnung, einheit, gewichtProEinheit, breite, laenge, hohe));
            }

            return listArtikels;
        }
    }
}
