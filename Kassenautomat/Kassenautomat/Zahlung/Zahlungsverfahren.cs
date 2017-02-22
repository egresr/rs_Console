using System;

namespace Kassenautomat.Zahlung
{
    class Zahlungsverfahren
    {



        public double Restbetrag { get; set; }
        double parkGebuer;

        public Zahlungsverfahren(double parkGebuer)
        {
            this.parkGebuer = parkGebuer;

            while (RestBetragRechner.ReichtEingezahlteSumme(parkGebuer))
            {
                DisplayAusgabeRestBetrag();
                BlockGeldEinnahme.Einwurf(Console.ReadLine());
            }

            ZeichneEinbezahlteEintraege();
        }

        private void ZeichneEinbezahlteEintraege()
        {
            Console.Clear();
            foreach (var item in GeldEingangsFachBanknoten.listBanknoten)
            {
                Console.WriteLine("{0},- Euro", item.NennWert);
            }

            foreach (var item in GeldEingangsFachMuenzen.listMuenzen)
            {
                if (item.NennWert < 100)
                    Console.WriteLine("{0} Cent", item.NennWert);
                if (item.NennWert >= 100)
                    Console.WriteLine("{0} Euro", item.NennWert / 100);
            }
            Console.ReadLine();
        }

        private void DisplayAusgabeRestBetrag()
        {
            Console.Clear();
            Console.WriteLine(" Banknote >> bXXX <<");
            Console.WriteLine(" Münze \t  >> mXXX <<");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");


            Console.WriteLine("\n\tParkgebüren : \t\t{0:0.00} Euro ", parkGebuer);
            Console.WriteLine("\n\tEinbezahlt  : \t\t{0:0.00} Euro ", RestBetragRechner.gesammtSumme);
            Console.WriteLine("\n\tzuzahlender Betrag  : \t{0:0.00} Euro ", RestBetragRechner.GetZuzahlenderBetrag(parkGebuer));
            Console.Write("\n\tGeldeinwurf : \t\t");
        }
        private void DisplayAusgabeRestgeldEntnehmen()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("\n\tRestgeld : {0:0.00} Euro ", Restbetrag * (-1));
            Console.Write("\n\tRestgeld entnehmen.");
        }

        private void DisplayAusgabe()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - -");
            Console.Write("\n\t Parkschein wird ausgegeben.");
        }
    }
}