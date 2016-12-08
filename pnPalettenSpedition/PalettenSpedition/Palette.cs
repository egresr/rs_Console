using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{
    class Palette
    {
        static int gesammtePalettenAnzahl;

        int id = 1;
        int laenge = 1200; //mm
        int breite = 800; //mm
        int hohe = 144; //mm
        int gewicht = 25; //kg

        public int GesammtePalettenAnzahl { get { return gesammtePalettenAnzahl; } }
        public int Id { get { return id; } }
        public int Laenge { get { return laenge; } }
        public int Breite { get { return breite; } }
        public int Hohe { get { return hohe; } }
        public double Gewicht { get { return gewicht; } }

        public Palette()
        {
            id = id + GesammtePalettenAnzahl;
            gesammtePalettenAnzahl++;
        }
    }
}
