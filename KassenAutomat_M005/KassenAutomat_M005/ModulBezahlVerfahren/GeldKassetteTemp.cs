using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenAutomat_M005.ModulBezahlVerfahren
{
    class GeldKassetteTemp
    {
        List<Muenze> listMuenzen;
        List<Banknote> listBanknoten;

        //public double GesammtSumme { get; set; }

        public void BucheZu(string geldArt, int nennWert)
        {
            if (geldArt == "Muenze")
            {
                if (listMuenzen == null)
                {
                    listMuenzen = new List<Muenze>();
                }

                listMuenzen.Add(new Muenze(nennWert));
            }

            if (geldArt == "Banknote")
            {
                if (listBanknoten == null)
                {
                    listBanknoten = new List<Banknote>();
                }

                listBanknoten.Add(new Banknote(nennWert));
            }
        }

        public double GetGesammtSumme()
        {
            int summeMuenzen = 0;
            int summeBanknoten = 0;

            if (listMuenzen != null)
            {
                foreach (var item in listMuenzen)
                {
                    summeMuenzen += item.NennWert;
                }
            }

            if (listBanknoten != null)
            {
                foreach (var item in listBanknoten)
                {
                    summeBanknoten += item.NennWert;
                }
            }

            return (double)summeBanknoten + summeMuenzen / 100;
        }
    }
}
