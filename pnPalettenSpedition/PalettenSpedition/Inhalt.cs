using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{
    class Inhalt
    {
        int id;
        double laenge; //mm
        double breite; //mm
        double hohe; //mm
        double gewicht; //kg

        List<Artikel> listArtikels;

        public Inhalt(int id, double laenge, double breite, double hohe, double gewicht, List<Artikel> listArtikels)
        {
            this.id = id;
            this.laenge = laenge;
            this.breite = breite;
            this.hohe = hohe;
            this.gewicht = gewicht;
            this.listArtikels = listArtikels;
        }
    }
}
