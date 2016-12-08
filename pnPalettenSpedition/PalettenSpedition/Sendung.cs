using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{

    //
    //Inhalt für eine Palette wird generiert
    //

    class Sendung
    {
        static int gesammteSendungAnzahl;

        Palette palette;
        Artikel artikel;

        public Sendung(int sendungId, Artikel artikel, Palette palette)
        {
            sendungId += gesammteSendungAnzahl;
            gesammteSendungAnzahl++;
            this.palette = palette;
            this.artikel = artikel;
        }
    }

    class aaa
    {
        static int gesammteSendungAnzahl;

        Palette palette;
        Artikel artikel;

        public aaa(int sendungId, Artikel artikel, Palette palette)
        {
            sendungId += gesammteSendungAnzahl;
            gesammteSendungAnzahl++;
            this.palette = palette;
            this.artikel = artikel;
        }
    }
}
