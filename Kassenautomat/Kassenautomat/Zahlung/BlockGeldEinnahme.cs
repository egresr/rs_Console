using System;

namespace Kassenautomat.Zahlung
{
    static class BlockGeldEinnahme
    {
        static public void Einwurf(string value)
        {
            string tmpWert = "";
            int nennWert = 0;

            Muenze muenze;
            Banknote banknote;

            //Neue string, ohne Zeichen b und n, bilden
            for (int i = 1; i < value.Length; i++)
            {
                tmpWert += value[i];
            }

            if (Int32.TryParse(tmpWert, out nennWert))
            {
                if (value[0] == 'b')
                {
                    banknote = new Banknote(nennWert);

                    if (BlockGeldPruefer.PreufeBanknote(banknote))
                    {
                        GeldEingangsFachBanknoten.listBanknoten.Add(banknote);
                    }

                    else
                        BlockGeldAusgabe.GebeNichtErkannteZahlungsmittelAus();
                }

                if (value[0] == 'm')
                {
                    muenze = new Muenze(nennWert);

                    if (BlockGeldPruefer.PreufeMuenze(muenze))
                    {
                        GeldEingangsFachMuenzen.listMuenzen.Add(muenze);
                    }

                    else
                        BlockGeldAusgabe.GebeNichtErkannteZahlungsmittelAus();
                }
            }
        }
    }
}
