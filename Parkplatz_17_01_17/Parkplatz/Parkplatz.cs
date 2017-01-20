using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class Parkplatz
    {
        Position startPosition;
        Position position;
        int breite = 4;
        int laenge = 3;

        PflasterStein pflasterStein;
        ConsoleColor pflasterSteinFarbe;
        char pflasterSteinZeichen;

        List<PflasterStein> listPflasterSteineFuerParkplatz;

        public Parkplatz(Position position, ConsoleColor pflasterSteinFarbe, char pflasterSteinZeichen)
        {
            startPosition = position;
            this.position = new Position(position);

            this.pflasterSteinFarbe = pflasterSteinFarbe;
            this.pflasterSteinZeichen = pflasterSteinZeichen;
            pflasterStein = new PflasterStein(this.position, pflasterSteinZeichen, pflasterSteinFarbe);

            ErzeugeListPflasterSteineFuerParkplatz();


        }
        public Parkplatz(Parkplatz parkplatz)
        {
            position = new Position(parkplatz.position);
        }

        private void ErzeugeListPflasterSteineFuerParkplatz()
        {
            listPflasterSteineFuerParkplatz = new List<PflasterStein>();

            for (int i = 0; i < laenge; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    listPflasterSteineFuerParkplatz.Add(new PflasterStein(position, pflasterSteinZeichen, pflasterSteinFarbe));
                    position.KoordinateX += 1;
                }
                position.KoordinateX = startPosition.KoordinateX;
                position.KoordinateY += 1;
            }
        }

        public void Zeichne()
        {
            foreach (PflasterStein  pflasterstein in listPflasterSteineFuerParkplatz)
            {
                pflasterstein.Zeichne();
            }
        }

    }
}
