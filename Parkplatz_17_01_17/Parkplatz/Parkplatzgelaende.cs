using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class Parkplatzgelaende
    {
        Position startPosition;

        Position positionEckeLinksOben;
        Position positionEckeRechtsOben;
        Position positionEckeLinksUnten;
        Position positionEckeRechtsUnten;

        MauerAussen mauerAussenLinks;
        MauerAussen mauerAussenRechts;
        MauerAussen mauerAussenOben;
        MauerAussen mauerAussenUnten;



        public Position PositionEckeLinksOben { get { return positionEckeLinksOben; } }
        public Position PositionEckeRechtsOben { get { return positionEckeRechtsOben; } }
        public Position PositionEckeLinksUnten { get { return positionEckeLinksUnten; } }
        public Position PositionEckeRechtsUnten { get { return positionEckeRechtsUnten; } }


        public Parkplatzgelaende( int abstandLinks, int abstandRechts, int abstandOben, int  abstandUnten)
        {
            BestimmeStartPosition(abstandLinks, abstandRechts, abstandOben, abstandUnten);
            BestimmePositionenAlleEckenParkplatzgelaende(abstandLinks, abstandRechts, abstandOben, abstandUnten);
            ErzeugeAlleAussenMauer();
        }



        private void BestimmeStartPosition(int abstandLinks, int abstandRechts, int abstandOben, int abstandUnten)
        {
            startPosition = new Position(abstandLinks, abstandOben);
        }
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
        //Aussenmauer
        private void ErzeugeAlleAussenMauer()
        {
            int mauerLaengeVertikal = BestimmeLaengeMauerVertikal();
            int mauerLaengeHorisontal = BestimmeLaengeMauerHorizontal();

            ErzeugeMauerAussenLinks(mauerLaengeVertikal);
            ErzeugeMauerAussenRechts(mauerLaengeVertikal);
            ErzeugeMauerAussenOben(mauerLaengeHorisontal);
            ErzeugeMauerAussenUnten(mauerLaengeHorisontal);

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
       
        //Trennmauer
        
       
        
    }
}
