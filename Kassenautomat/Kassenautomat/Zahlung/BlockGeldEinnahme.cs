using System;

namespace Kassenautomat.Zahlung
{
    class BlockGeldEinnahme
    {
        public static Muenze Muenze { get; private set; }
        
        static public void Einwurf(string value)
        {
            string tmpWert = "";
            int nennWert = 0;

            
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
                    Muenze = new Muenze(nennWert);

                    if (BlockGeldPruefer.PreufeMuenze(Muenze))
                    {
                        GeldEingangsFachMuenzen.listMuenzen.Add(Muenze);
                    }

                    else
                        BlockGeldAusgabe.GebeNichtErkannteZahlungsmittelAus();
                }
            }
        }
    }
}
