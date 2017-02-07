using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class Parkplatzgelaende
    {
        #region ----- Fahrweg
        // Fahrweg
        int fahrWegBreite = 4;
        char fahrWegPflasterSteinZeichen = '░';
        ConsoleColor fahrWegPflasterSteinFarbe = ConsoleColor.DarkGray;
        #endregion --- Fahrweg

        #region ----- Parkplatz
        //Parkplatz
        int parkPlatzBreite = 4;
        int parkPlatzLaenge = 3;
        char parkPlatzPflasterSteinZeichen = '▒';
        ConsoleColor parkPlatzPflasterSteinFarbe = ConsoleColor.DarkRed;
        #endregion --- Parkplatz

        #region ----- Positionen
        Position startPosition;

        Position positionEckeLinksOben;
        Position positionEckeRechtsOben;
        Position positionEckeLinksUnten;
        Position positionEckeRechtsUnten;

        #endregion --- Positionen

        #region ----- MauerAussen
        MauerAussen mauerAussenLinks;
        MauerAussen mauerAussenRechts;
        MauerAussen mauerAussenOben;
        MauerAussen mauerAussenUnten;
        #endregion --- MauerAussen

        #region ----- Trennmauer
        TrennMauer trennMauerOben;
        TrennMauer trennMauerUnten;
        #endregion --- Trennmauer

        #region ----- Fahrweg
        FahrWeg fahrWegLinks;
        FahrWeg fahrWegRechts;
        FahrWeg fahrWegOben;
        FahrWeg fahrWegMitte;
        FahrWeg fahrWegUnten;
        #endregion --- Fahrweg

        #region ----- Eigenschaften
        public Position PositionEckeLinksOben { get { return positionEckeLinksOben; } }
        public Position PositionEckeRechtsOben { get { return positionEckeRechtsOben; } }
        public Position PositionEckeLinksUnten { get { return positionEckeLinksUnten; } }
        public Position PositionEckeRechtsUnten { get { return positionEckeRechtsUnten; } }
        #endregion --- Eigenschaften

        #region ----- Konstruktor
        public Parkplatzgelaende(int abstandLinks, int abstandRechts, int abstandOben, int abstandUnten)
        {
            BestimmeStartPosition(abstandLinks, abstandRechts, abstandOben, abstandUnten);
            BestimmePositionenAlleEckenParkplatzgelaende(abstandLinks, abstandRechts, abstandOben, abstandUnten);

            ErzeugeAlleAussenMauer();
            ZeichneAlleAussenMauer();

            EreugeAlleTrennMauer();
            ZeichneAlleTrennMauer();

            ErzeugeAlleFahrwege();
            ZeichneAlleFahrwege();



        }


        #endregion --- Konstruktor


        private void BestimmeStartPosition(int abstandLinks, int abstandRechts, int abstandOben, int abstandUnten)
        {
            startPosition = new Position(abstandLinks, abstandOben);
        }
        #region ----- Ecken von Parkgelaende
        //Ecken von Parkgelaende
        private void BestimmePositionenAlleEckenParkplatzgelaende(int abstandLinks, int abstandRechts, int abstandOben, int abstandUnten)
        {
            BestimmePositionEckeLinksOben(abstandLinks, abstandOben);
            BestimmePositionEckeRechtsOben(abstandRechts, abstandOben);
            BestimmePositionEckeLinksUnten(abstandLinks, abstandUnten);
            BestimmePositionEckeRechtsUnten(abstandRechts, abstandUnten);
        }
        private void BestimmePositionEckeLinksOben(int abstandLinks, int abstandOben)
        {
            int koordinateX = abstandLinks;
            int koordinateY = abstandOben;
            positionEckeLinksOben = new Position(koordinateX, koordinateY);
        }
        private void BestimmePositionEckeRechtsOben(int abstandRechts, int abstandOben)
        {
            int koordinateX = Console.WindowWidth - abstandRechts - 1;
            int koordinateY = abstandOben;
            positionEckeRechtsOben = new Position(koordinateX, koordinateY);
        }
        private void BestimmePositionEckeLinksUnten(int abstandLinks, int abstandUnten)
        {
            int koordinateX = abstandLinks;
            int koordinateY = Console.WindowHeight - abstandUnten - 1;
            positionEckeLinksUnten = new Position(koordinateX, koordinateY);
        }
        private void BestimmePositionEckeRechtsUnten(int abstandRechts, int abstandUnten)
        {
            int koordinateX = Console.WindowWidth - abstandRechts - 1;
            int koordinateY = Console.WindowHeight - abstandUnten - 1;
            positionEckeRechtsUnten = new Position(koordinateX, koordinateY);
        }

        #endregion --- Ecken von Parkgelaende

        #region ----- Aussenmauer
        //Aussenmauer
        private void ErzeugeAlleAussenMauer()
        {
            int mauerLaengeVertikal = BestimmeLaengeMauerVertikal();
            int mauerLaengeHorisontal = BestimmeLaengeMauerHorizontal();

            ErzeugeMauerAussenLinks(mauerLaengeVertikal);
            ErzeugeMauerAussenRechts(mauerLaengeVertikal);
            ErzeugeMauerAussenOben(mauerLaengeHorisontal);
            ErzeugeMauerAussenUnten(mauerLaengeHorisontal);
        }
        private void ZeichneAlleAussenMauer()
        {
            mauerAussenLinks.Zeichne();
            mauerAussenRechts.Zeichne();
            mauerAussenOben.Zeichne();
            mauerAussenUnten.Zeichne();
        }
        private int BestimmeLaengeMauerVertikal()
        {
            return positionEckeLinksUnten.KoordinateY - positionEckeLinksOben.KoordinateY + 1;
        }
        private int BestimmeLaengeMauerHorizontal()
        {
            return positionEckeRechtsOben.KoordinateX - positionEckeLinksOben.KoordinateX + 1;
        }
        private void ErzeugeMauerAussenLinks(int mauerLaengeVertikal)
        {
            mauerAussenLinks = new MauerAussen(positionEckeLinksOben, Richtung.nachUnten, mauerLaengeVertikal, ConsoleColor.Red, '█');
        }
        private void ErzeugeMauerAussenRechts(int mauerLaengeVertikal)
        {
            mauerAussenRechts = new MauerAussen(positionEckeRechtsOben, Richtung.nachUnten, mauerLaengeVertikal, ConsoleColor.Red, '█');
        }
        private void ErzeugeMauerAussenOben(int mauerLaengeHorisontal)
        {
            mauerAussenOben = new MauerAussen(positionEckeLinksOben, Richtung.nachRechts, mauerLaengeHorisontal, ConsoleColor.Red, '▄');
            //mauerAussenOben = new MauerAussen(positionEckeLinksOben, Richtung.nachRechts, mauerLaengeHorisontal, ConsoleColor.Red, '█');
        }
        private void ErzeugeMauerAussenUnten(int mauerLaengeHorisontal)
        {
            mauerAussenUnten = new MauerAussen(positionEckeLinksUnten, Richtung.nachRechts, mauerLaengeHorisontal, ConsoleColor.Red, '▀');
            //mauerAussenUnten = new MauerAussen(positionEckeLinksUnten, Richtung.nachRechts, mauerLaengeHorisontal, ConsoleColor.Red, '█');
        }
        #endregion --- Aussenmauer

        #region ----- Trennmauer
        //Trennmauer
        private void EreugeAlleTrennMauer()
        {
            Position startPosition = new Position(positionEckeLinksOben);


            Position endPosition = new Position(PositionEckeRechtsOben);
        }
        private void ZeichneAlleTrennMauer()
        {
            
        }
        #endregion ---Trennmauer

        #region ----- Fahrweg
        //Fahrweg
        private void ErzeugeAlleFahrwege()
        {
            ErzeugeFahrwegLinks();
            ErzeugeFahrwegRechts();
            ErzeugeFahrwegMitte();
            ErzeugeFahrwegOben();
            ErzeugeFahrwegUnten();
        }
        private void ErzeugeFahrwegLinks()
        {
            Position startPositionFahrweg = new Position(positionEckeLinksOben);
            startPositionFahrweg.KoordinateX += 2;
            startPositionFahrweg.KoordinateY += parkPlatzLaenge + 2;

            Position endPositionFahrweg = new Position(positionEckeLinksUnten);
            endPositionFahrweg.KoordinateX += 2;
            endPositionFahrweg.KoordinateY -= 0;

            fahrWegLinks = new FahrWeg(startPositionFahrweg, endPositionFahrweg, fahrWegBreite, Richtung.nachUnten, fahrWegPflasterSteinZeichen, fahrWegPflasterSteinFarbe);
        }
        private void ErzeugeFahrwegRechts()
        {
            Position startPositionFahrweg = new Position(positionEckeRechtsOben);
            startPositionFahrweg.KoordinateX -= fahrWegBreite + 1;
            startPositionFahrweg.KoordinateY += parkPlatzLaenge + 2;

            Position endPositionFahrweg = new Position(positionEckeRechtsUnten);
            endPositionFahrweg.KoordinateX -= fahrWegBreite + 2;
            endPositionFahrweg.KoordinateY -= 0;

            fahrWegRechts = new FahrWeg(startPositionFahrweg, endPositionFahrweg, fahrWegBreite, Richtung.nachUnten, fahrWegPflasterSteinZeichen, fahrWegPflasterSteinFarbe);
        }
        private void ErzeugeFahrwegOben()
        {
            Position startPositionFahrweg = new Position(positionEckeLinksOben);
            startPositionFahrweg.KoordinateX += fahrWegBreite + 1;
            startPositionFahrweg.KoordinateY += parkPlatzLaenge + 2;

            Position endPositionFahrweg = new Position(positionEckeRechtsOben);
            endPositionFahrweg.KoordinateX -= fahrWegBreite + 1;
            endPositionFahrweg.KoordinateY += parkPlatzLaenge + 1;

            fahrWegOben = new FahrWeg(startPositionFahrweg, endPositionFahrweg, fahrWegBreite, Richtung.nachRechts, fahrWegPflasterSteinZeichen, fahrWegPflasterSteinFarbe);
        }

        private void ErzeugeFahrwegMitte()
        {
            Position startPositionFahrweg = new Position(positionEckeLinksOben);
            startPositionFahrweg.KoordinateX += fahrWegBreite + 1;
            startPositionFahrweg.KoordinateY += parkPlatzLaenge * 3 + fahrWegBreite + 3;

            Position endPositionFahrweg = new Position(positionEckeRechtsOben);
            endPositionFahrweg.KoordinateX -= fahrWegBreite + 1;
            endPositionFahrweg.KoordinateY += parkPlatzLaenge * 3 + fahrWegBreite + 3;

            fahrWegMitte = new FahrWeg(startPositionFahrweg, endPositionFahrweg, fahrWegBreite, Richtung.nachRechts, fahrWegPflasterSteinZeichen, fahrWegPflasterSteinFarbe);
        }
        private void ErzeugeFahrwegUnten()
        {
            Position startPositionFahrweg = new Position(positionEckeLinksUnten);
            startPositionFahrweg.KoordinateX += fahrWegBreite + 1;
            startPositionFahrweg.KoordinateY -= parkPlatzLaenge + fahrWegBreite + 1;

            Position endPositionFahrweg = new Position(positionEckeRechtsUnten);
            endPositionFahrweg.KoordinateX -= fahrWegBreite + 1;
            endPositionFahrweg.KoordinateY -=  parkPlatzLaenge + fahrWegBreite + 1;

            fahrWegUnten = new FahrWeg(startPositionFahrweg, endPositionFahrweg, fahrWegBreite, Richtung.nachRechts, fahrWegPflasterSteinZeichen, fahrWegPflasterSteinFarbe);
        }
        private void ZeichneAlleFahrwege()
        {
            fahrWegLinks.Zeichne();
            fahrWegRechts.Zeichne();
            fahrWegOben.Zeichne();
            fahrWegMitte.Zeichne();
            fahrWegUnten.Zeichne();
        }

        #endregion --- Fahrweg

    }
}
