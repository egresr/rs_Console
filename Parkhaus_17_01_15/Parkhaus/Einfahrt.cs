using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Einfahrt
    {
        Position position;
        int laenge = 3;
        int breite = 6;

        List<Pflasterstein> listPflastersteine;

        public int KoordinateX { get { return KoordinateX; } }
        public int KoordinateY { get { return KoordinateY; } }

        public Einfahrt(int koordinateX, int koordinateY) //Koordinate von EckeLinksUnten
        {
            BestimmePosition(koordinateX, koordinateY);
            ErzeugeListPflastersteine();
        }

        private void BestimmePosition(int koordinateX, int koordinateY)
        {
            koordinateX += 1;
            koordinateY = koordinateY - laenge + 1;

            position = new Position(koordinateX, koordinateY);
        }

        private void ErzeugeListPflastersteine()
        {
            int nextKoordinateX = position.KoordinateX;
            int nextKoordinateY = position.KoordinateY;

            listPflastersteine = new List<Pflasterstein>();

            for (int i = 0; i < laenge; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    listPflastersteine.Add(new Pflasterstein(nextKoordinateX + j, nextKoordinateY + i));
                }
            }
        }

        public void Zeichne()
        {
            foreach (Pflasterstein pflasterstein in listPflastersteine)
            {
                pflasterstein.Zeichne();
            }
        }
    }
}
