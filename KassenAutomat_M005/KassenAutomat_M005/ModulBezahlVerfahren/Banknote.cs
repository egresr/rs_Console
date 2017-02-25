using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenAutomat_M005.ModulBezahlVerfahren
{
    class Banknote
    {
        string bezeichnung = "Euro";

        public string Bezeichnung
        {
            get { return bezeichnung; }
        }
        public int NennWert { get; set; }

        public Banknote(int nennWert)
        {
            NennWert = nennWert;
        }

    }
}
