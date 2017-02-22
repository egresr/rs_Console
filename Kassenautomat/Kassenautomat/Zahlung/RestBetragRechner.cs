using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassenautomat.Zahlung
{
    static class RestBetragRechner
    {
        static public double gesammtSumme;
        static public bool ReichtEingezahlteSumme(double parkGebuer)
        {
            gesammtSumme = GetSummeBanknoten() + GetSummeMuenzen();

            return parkGebuer > gesammtSumme;
        }

        static public double GetZuzahlenderBetrag(double parkGebuer)
        {
            return parkGebuer - gesammtSumme;
        }

        static private double GetSummeBanknoten()
        {
            double summeBanknoten = 0.0;
            foreach (var item in GeldEingangsFachBanknoten.listBanknoten)
            {
                summeBanknoten += item.NennWert;
            }

            return summeBanknoten;   
        }

        static private double GetSummeMuenzen()
        {
            double summeMuenzen = 0.0;

            foreach (var item in GeldEingangsFachMuenzen.listMuenzen)
            {
                summeMuenzen += item.NennWert;
            }

            return summeMuenzen / 100;
        }
    }
}
