using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class FahrWeg
    {
        Position startPosition;
        Position endPosition;
        int fahrWegBreite;
        int fahrWegLaenge;
        Richtung fahrWegRichtung;
        char pflasterSteinZeichen;
        ConsoleColor pflasterSteinFarbe;

        Position positionPflasterStein;
        List<PflasterStein> listPflasterSteine;


        public FahrWeg(Position startPosition, Position endPosition, int fahrWegBreite, Richtung fahrWegRichtung, char pflasterSteinZeichen, ConsoleColor pflasterSteinFarbe)
        {
            this.startPosition = new Position(startPosition);
            this.endPosition = new Position(endPosition);
            this.fahrWegBreite = fahrWegBreite;
            this.fahrWegRichtung = fahrWegRichtung;
            this.pflasterSteinZeichen = pflasterSteinZeichen;
            this.pflasterSteinFarbe = pflasterSteinFarbe;

            BestimmeLaengeFahrWeg();
            ErzeugeListPflasterSteineFuerFahrweg();
        }
        private void BestimmeLaengeFahrWeg()
        {
            if (fahrWegRichtung == Richtung.nachRechts)
                fahrWegLaenge = endPosition.KoordinateX - startPosition.KoordinateX;

            if (fahrWegRichtung == Richtung.nachUnten)
                fahrWegLaenge = endPosition.KoordinateY - startPosition.KoordinateY;
        }

        private void ErzeugeListPflasterSteineFuerFahrweg()
        {
            listPflasterSteine = new List<PflasterStein>();
            positionPflasterStein = new Position(startPosition);

            if (fahrWegRichtung == Richtung.nachRechts) //Horizontal
            {
                int tmpBreiteLaenge = fahrWegBreite;
                fahrWegBreite = fahrWegLaenge;
                fahrWegLaenge = tmpBreiteLaenge;

                for (int i = 0; i < fahrWegLaenge; i++)
                {
                    for (int j = 0; j < fahrWegBreite; j++)
                    {
                        
                        listPflasterSteine.Add(new PflasterStein(positionPflasterStein, pflasterSteinZeichen, pflasterSteinFarbe));
                        positionPflasterStein.KoordinateX += 1;
                    }

                    positionPflasterStein.KoordinateY += 1;
                    positionPflasterStein.KoordinateX = startPosition.KoordinateX;
                }
            }

            if (fahrWegRichtung == Richtung.nachUnten) //Vertikal
            {
                for (int i = 0; i <= fahrWegLaenge; i++)
                {
                    for (int j = 0; j < fahrWegBreite; j++)
                    {
                        positionPflasterStein = new Position(positionPflasterStein);
                        listPflasterSteine.Add(new PflasterStein(positionPflasterStein, pflasterSteinZeichen, pflasterSteinFarbe));
                        positionPflasterStein.KoordinateX += 1;
                    }
                    positionPflasterStein.KoordinateX = startPosition.KoordinateX;
                    positionPflasterStein = BestimmeNextPflasterSteinPosition(positionPflasterStein);
                }
            }

        }
        private Position BestimmeNextPflasterSteinPosition(Position pflasterSteinPosition)
        {
            if (fahrWegRichtung == Richtung.nachLinks)
            {
                pflasterSteinPosition.KoordinateY -= 1;
            }

            if (fahrWegRichtung == Richtung.nachRechts)
                pflasterSteinPosition.KoordinateY += 1;

            if (fahrWegRichtung == Richtung.nachOben)
                pflasterSteinPosition.KoordinateY -= 1;

            if (fahrWegRichtung == Richtung.nachUnten)
                pflasterSteinPosition.KoordinateY += 1;

            return pflasterSteinPosition;

        }
        public void Zeichne()
        {
            foreach (PflasterStein pflasterStein in listPflasterSteine)
            {
                pflasterStein.Zeichne();
            }
        }
    }
}
