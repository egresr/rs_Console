using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class ParkhausRaum
    {
        int abstandVonOben;
        int abstandVonUnten;
        int abstandVonLinks;
        int abstandVonRechts;

        Position eckeLinksOben;
        Position eckeLinksUnten;
        Position eckeRechtsOben;
        Position eckeRechtsUnten;

        Einfahrt einfahrt;
        Parkplatz parkplatz;

        public int EckeLinksOben { get { return eckeLinksOben.KoordinateX; } }
        public int EckeLinksUnten { get { return eckeLinksUnten.KoordinateX; } }
        public int EckeRechtsOben { get { return eckeRechtsOben.KoordinateX; } }
        public int EckeRechtsUnten { get { return eckeRechtsUnten.KoordinateX; } }
        public Einfahrt Einfahrt { get { return einfahrt; } }
        public Parkplatz Parkplatz { get { return parkplatz; } }

        public ParkhausRaum(int abstandVonOben, int abstandVonUnten, int abstandVonLinks, int abstandVonRechts)
        {
            this.abstandVonOben = abstandVonOben;
            this.abstandVonUnten = abstandVonUnten;
            this.abstandVonLinks = abstandVonLinks;
            this.abstandVonRechts = abstandVonRechts;

            BestimmePosition_EckeLinksOben();
            BestimmePosition_EckeLinksUnten();
            BestimmePosition_EckeRechtsOben();
            BestimmePosition_EckeRechtsUnten();

            ZeichneWandOben();
            ZeichneWandUnten();
            ZeichneWandLinks();
            ZeichneWandRechts();

            ZeichneEinfahrt(eckeLinksUnten.KoordinateX + 1, eckeLinksUnten.KoordinateY + 1);

            parkplatz = new Parkplatz(5, 5);


        }

        //Alle Positionen von Ecken bestimmen
        private void BestimmePosition_EckeLinksOben()
        {
            int koordinateX = abstandVonLinks;
            int koordinateY = abstandVonOben;

            eckeLinksOben = new Position(koordinateX, koordinateY);
        }
        private void BestimmePosition_EckeRechtsOben()
        {
            int koordinateX = Console.WindowWidth - abstandVonRechts - 1;
            int koordinateY = abstandVonOben;

            eckeRechtsOben = new Position(koordinateX, koordinateY);
        }
        private void BestimmePosition_EckeLinksUnten()
        {
            int koordinateX = abstandVonLinks;
            int koordinateY = Console.WindowHeight - abstandVonUnten - 1;

            eckeLinksUnten = new Position(koordinateX, koordinateY);
        }
        private void BestimmePosition_EckeRechtsUnten()
        {
            int koordinateX = Console.WindowWidth - abstandVonRechts - 1;
            int koordinateY = Console.WindowHeight - abstandVonUnten - 1;

            eckeRechtsUnten = new Position(koordinateX, koordinateY);
        }

        //Waende Zeichnen
        private void ZeichneWandOben()
        {
            int laenge = eckeRechtsOben.KoordinateX - eckeLinksOben.KoordinateX;
            Wand wandOben = new Wand(eckeLinksOben.KoordinateX, eckeLinksOben.KoordinateY, laenge, Richtung.nachRechts);
            wandOben.Zeichne();
        }
        private void ZeichneWandUnten()
        {
            int laenge = eckeRechtsOben.KoordinateX - eckeLinksOben.KoordinateX;
            Wand wandUnten = new Wand(eckeLinksUnten.KoordinateX, eckeLinksUnten.KoordinateY, laenge, Richtung.nachRechts);
            wandUnten.Zeichne();
        }
        private void ZeichneWandLinks()
        {
            int laenge = eckeLinksUnten.KoordinateY - eckeLinksOben.KoordinateY;
            Wand wandLinks = new Wand(eckeLinksOben.KoordinateX, eckeLinksOben.KoordinateY, laenge, Richtung.nachUnten);
            wandLinks.Zeichne();
        }
        private void ZeichneWandRechts()
        {
            int laenge = eckeRechtsUnten.KoordinateY - eckeRechtsOben.KoordinateY + 1;
            Wand wandRechts = new Wand(eckeRechtsOben.KoordinateX, eckeRechtsOben.KoordinateY, laenge, Richtung.nachUnten);
            wandRechts.Zeichne();
        }

        //Parkhaus Ausstatung Zeichnen
        private void ZeichneEinfahrt(int koordinateX, int koordinateY)
        {
            Einfahrt einfahrtPrototyp = new Einfahrt(); //Prototyp wird erstellt um die Einfahrt laenge zu ermitteln
                  
            koordinateY = koordinateY - einfahrtPrototyp.Laenge;
            einfahrt = new Einfahrt(koordinateX, koordinateY);
            einfahrt.Zeichne();
        }
    }
}
