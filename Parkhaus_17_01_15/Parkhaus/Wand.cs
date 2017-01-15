using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Wand
    {
        public enum Richtung { nachLinks, nachRechts, nachOben, nachUnten }

        Position position;
        int laenge;
        Richtung richtung;
        List<Mauerstein> listMauersteine;

        public Wand(int koordinateX, int koordinateY, int laenge, Richtung richtung)
        {
            position = new Position(koordinateX, koordinateY);
            this.laenge = laenge;
            this.richtung = richtung;

            ErzeugeListMauersteine();
        }

        private void ErzeugeListMauersteine()
        {
            int nextPositionX = position.KoordinateX;
            int nextPositionY = position.KoordinateY;

            listMauersteine = new List<Mauerstein>();

            for (int i = 0; i < laenge; i++)
            {
                if (richtung == Richtung.nachLinks)
                    nextPositionX = position.KoordinateX - i;
                else if(richtung == Richtung.nachRechts)
                    nextPositionX = position.KoordinateX + i;

                if (richtung == Richtung.nachOben)
                    nextPositionY = position.KoordinateY - i;
                else if (richtung == Richtung.nachUnten)
                    nextPositionY = position.KoordinateY + i;

                listMauersteine.Add(new Mauerstein(nextPositionX, nextPositionY));
            }
        }

        public void Zeichne()
        {
            foreach (Mauerstein mauerstein in listMauersteine)
            {
                mauerstein.Zeichne();
            }
        }
    }
}
