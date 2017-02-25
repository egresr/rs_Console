using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenAutomat_M005.ModulBezahlVerfahren
{
    class Muenze
    {
        string centBezeichnung = "Cent";
        string euroBezeichnung = "Euro";
        public int NennWert { get; set; }
        public string Bezeichnung
        {
            get
            {
                if (NennWert < 100)
                    return centBezeichnung;
                else
                    return euroBezeichnung;
            }
        }

        public Muenze(int nennWert)
        {
            NennWert = nennWert;
        }
    }
}
