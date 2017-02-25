using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenAutomat_M005.ModulBezahlVerfahren
{
    static class IstSollPruefer
    {
        static public bool Pruefe()
        {
            bool vortsetzen = true;

            return vortsetzen;
        }

        static public bool Pruefe(double parkKosten, double gesammtSumme)
        {
            if (gesammtSumme < parkKosten)
                return true;
            return false;
        }
    }
}
