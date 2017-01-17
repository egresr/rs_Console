using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Parkhalle
    {
        ConsoleColor wandFarbe = ConsoleColor.DarkRed;
        Position eckeObenLinks;
        Position eckeObenRechts;
        Position eckeUntenLinks;
        Position eckeUntenRechts;

        Wand wandLinks;
        Wand wandRechts;
        Wand wandOben;
        Wand wandUnten;

        public Position EckeObenLinks { get { return eckeObenLinks; } }
        public Position EckeObenRechts { get { return eckeObenRechts; } }
        public Position EckeUntenLinks { get { return eckeUntenLinks; } }
        public Position EckeUntenRechts { get { return eckeUntenRechts; } }


        public Parkhalle(int abstandVonLinks, int abstandVonRechts, int abstandVonOben, int abstandVonUnten)
        {
            ErzeugePositionenAlleEcken(abstandVonLinks, abstandVonRechts, abstandVonOben, abstandVonUnten);
            ErzeugeAlleAussenWaende();
        }

        private int BestimmeWandLaengeVertikal()
        {
            return eckeUntenLinks.KoordinateY - eckeObenLinks.KoordinateY;
        }
        private int BestimmeWandLaengeHorizontal()
        {
            return eckeObenRechts.KoordinateX - eckeObenLinks.KoordinateX;
        }

        private void ErzeugeAlleAussenWaende()
        {
            ErzeugeWandLinks();
            ErzeugeWandRechts();
            ErzeugeWandOben();
            ErzeugeWandUnten();

        }
        private void ErzeugeWandLinks()
        {
            int laenge = BestimmeWandLaengeVertikal() + 1;
            wandLinks = new Wand(laenge, Richtung.nachUnten, wandFarbe, eckeObenLinks);
            wandLinks.Zeichne();
        }
        private void ErzeugeWandRechts()
        {
            int laenge = BestimmeWandLaengeVertikal() + 1;
            wandRechts = new Wand(laenge, Richtung.nachUnten, wandFarbe, eckeObenRechts);
            wandRechts.Zeichne();
        }
        private void ErzeugeWandOben()
        {
            int laenge = BestimmeWandLaengeHorizontal() + 1;
            wandOben = new Wand(laenge, Richtung.nachRechts, wandFarbe, eckeObenLinks);
            wandOben.Zeichne();
        }
        private void ErzeugeWandUnten()
        {
            int laenge = BestimmeWandLaengeHorizontal() + 1;
            wandUnten = new Wand(laenge, Richtung.nachRechts, wandFarbe, eckeUntenLinks);
            wandUnten.Zeichne();
        }

        private void ErzeugePositionenAlleEcken(int abstandVonLinks, int abstandVonRechts, int abstandVonOben, int abstandVonUnten)
        {
            ErzeugePositionEckeObenLinks(abstandVonLinks, abstandVonOben);
            ErzeugePositionEckeObenRechts(abstandVonRechts, abstandVonOben);
            ErzeugePositionEckeUntenLinks(abstandVonLinks, abstandVonUnten);
            ErzeugePositionEckeUntenRechts(abstandVonRechts, abstandVonUnten);
        }
        private void ErzeugePositionEckeObenLinks(int abstandVonLinks, int abstandVonOben)
        {
            int koordinateX = abstandVonLinks;
            int koordinateY = abstandVonOben;

            eckeObenLinks = new Position(koordinateX, koordinateY);
        }
        private void ErzeugePositionEckeObenRechts(int abstandVonRechts, int abstandVonOben)
        {
            int koordinateX = Console.WindowWidth - abstandVonRechts - 1;
            int koordinateY = abstandVonOben;

            eckeObenRechts = new Position(koordinateX, koordinateY);
        }
        private void ErzeugePositionEckeUntenLinks(int abstandVonLinks, int abstandVonUnten)
        {
            int koordinateX = abstandVonLinks;
            int koordinateY = Console.WindowHeight - abstandVonUnten - 1;

            eckeUntenLinks = new Position(koordinateX, koordinateY);
        }
        private void ErzeugePositionEckeUntenRechts(int abstandVonRechts, int abstandVonUnten)
        {
            int koordinateX = Console.WindowWidth - abstandVonRechts - 1;
            int koordinateY = Console.WindowHeight - abstandVonUnten - 1;

            eckeUntenRechts = new Position(koordinateX, koordinateY);
        }
    }
}
