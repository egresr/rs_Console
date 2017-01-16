using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Parkplatz
    {
        Position position;
        int breite = 3;
        int laenge = 3;

        List<Pflasterstein> listPflastersteine;

        public int KoordinateX { get { return position.KoordinateX; } }
        public int KoordinateY { get { return position.KoordinateY; } }

        public Parkplatz(Position position)
        {
            position = new Position(position.KoordinateX, position.KoordinateY);

        }
        public Parkplatz(int koordinateX, int koordinateY)
        {
            position = new Position(koordinateX, koordinateY);
            Erzeuge();
            Zeichne();
        }

        private void Erzeuge()
        {
            listPflastersteine = new List<Pflasterstein>();
            for (int i = 0; i < laenge; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    listPflastersteine.Add(new Pflasterstein(position.KoordinateX + j, position.KoordinateY + i));
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
