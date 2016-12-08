using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{
    class ArtikelBestand
    {
        public static void Ausgeben(List<Artikel> artikel)
        {
            AusgebenUeberschrift();
            foreach(Artikel item in artikel )
            {
                AusgebenArtikelDaten(item);
            }
        }

        private static void AusgebenUeberschrift()
        {
            Console.SetCursorPosition(0, 2);
            Console.Write("\t\t\t----- Artikel Bestand -----");
            Console.WriteLine("\n\n\t-------------------------------------------------------------");
        }

        private static void AusgebenArtikelDaten(Artikel artikel)
        {
            Console.WriteLine();
            Console.Write("\n\tArtikel ID\t\t:\t" + artikel.ID);
            Console.Write("\n\tBezeichnung\t\t:\t\"" + artikel.Bezeichnung+"\"");
            Console.Write("\n\tEinheit\t\t\t:\t" + artikel.Einheit);
            Console.Write("\n\tGewicht pro Einheit\t:\t" + artikel.GewichtProEinheit + "\tkg");
            Console.Write("\n\tBreite\t\t\t:\t" + artikel.Breite + "\tmm");
            Console.Write("\n\tLänge\t\t\t:\t" + artikel.Laenge + "\tmm");
            Console.Write("\n\tHohe\t\t\t:\t" + artikel.Hohe + "\tmm");
            //Console.WriteLine("\n\n\t. . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .");
            Console.WriteLine("\n\n\t.............................................................");
        }
    }
}