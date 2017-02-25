using System;

namespace KassenAutomat_M005.ModulBezahlVerfahren
{
    internal class BezahlVerfahren
    {
        private double parkKosten;

        bool vortsetzen = true;
        Display display;
        GeldKassetteTemp geldKasseteTemp = new GeldKassetteTemp();

        public string GeldArt { get; private set; }
        static public int NennWert { get; private set; }
        public double AktuelleKosten { get; private set; }


        public BezahlVerfahren(double parkKosten)
        {
            this.parkKosten = parkKosten;
            AktuelleKosten = parkKosten;

            display = new Display();

            GeldEinwurf();
        }

        private void GeldEinwurf()
        {
            while (vortsetzen)
            {
                display.Einschalten();
                if (!B_M_Separater())
                    continue;
                if (!GetNennWert())
                    continue;
                if (!GeldPruefer())
                    continue;

                BucheGeldEin();
                BerechneRestBetrag();
                IstSollPruefer.Pruefe(parkKosten, geldKasseteTemp.GetGesammtSumme());

            }
        }

        private void BerechneRestBetrag()
        {
            AktuelleKosten -= NennWert;
        }

        private void BucheGeldEin()
        {
            if(geldKasseteTemp == null)
            {
                geldKasseteTemp = new GeldKassetteTemp();
            }

            geldKasseteTemp.BucheZu(GeldArt, NennWert);

        }

        private bool GeldPruefer()
        {
            if (GeldArt == "Muenze")
            {
                return GeldNennWertReferenz.Vergleiche(GeldArt, NennWert);
            }

            if (GeldArt == "Banknote")
            {
                return GeldNennWertReferenz.Vergleiche(GeldArt, NennWert);
            }
            return false;
        }

        private bool GetNennWert()
        {
            string pruefString = "";
            int nennWert = 0;

            for (int i = 1; i < display.EingangString.Length; i++)
            {
                pruefString += display.EingangString[i];
            }

            if (int.TryParse(pruefString, out nennWert))
            {
                NennWert = nennWert;
                return true;
            }
                return false;
        }

        private bool B_M_Separater()
        {
            if (display.EingangString != "")
            {
                if (display.EingangString[0] == 'b')
                {
                    GeldArt = "Banknote";
                    return true;
                }

                if (display.EingangString[0] == 'm')
                {
                    GeldArt = "Muenze";
                    return true;
                }

                return false;
            }
            else
                return false;
        }
    }
}