using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenAutomat_M005.ModulBezahlVerfahren
{
    static class GeldNennWertReferenz
    {
        static int[] muenzenReferenz = new int[] { 1, 2, 5, 10, 20, 50, 100, 200 };
        static int[] banknotenReferenz = new int[] { 5, 10, 20, 50, 100, 200, 500 };


        internal static bool Vergleiche(string geldArt, int nennWert)
        {
            if(geldArt == "Muenze")
            {
                foreach (var item in muenzenReferenz)
                {
                    if (nennWert == item)
                    {
                        return true;
                    }
                }
            }

            if (geldArt == "Banknote")
            {
                foreach (var item in banknotenReferenz)
                {
                    if (nennWert == item)
                    {
                        return true;
                    }

                }
            }

            return false;
        }
    }
}
