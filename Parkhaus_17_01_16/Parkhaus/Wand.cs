using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Wand
    {
        int laenge;
        Richtung richtung;
        ConsoleColor farbe;
        Position position;
        List<Ziegel> listZiegels;

        public int KoordinateX { get { return position.KoordinateX; } set { } }
        public int koordinateY { get { return position.KoordinateX; } set { } }
        public Ziegel Ziegel { get { return listZiegels[laenge-1]; } set { } }


        public Wand(int laenge, Richtung richtung, ConsoleColor farbe, Position position)
        {
            this.laenge = laenge;
            this.richtung = richtung;
            this.farbe = farbe;
            this.position = new Position(position);

            ErzeugeListZiegels();
        }


        private void ErzeugeListZiegels()
        {
            listZiegels = new List<Ziegel>();

            for (int i = 0; i < laenge; i++)
            {                
                listZiegels.Add(new Ziegel(position, farbe));
                BestimmeNextZiegelPosition(i);
            }
        }

        private void BestimmeNextZiegelPosition(int i)
        {
            if (richtung == Richtung.nachRechts)
                position.KoordinateX += 1;
            if (richtung == Richtung.nachLinks)
                position.KoordinateX -= 1;
            if (richtung == Richtung.nachUnten)
                position.KoordinateY += 1;
            if (richtung == Richtung.nachOben)
                position.KoordinateY -= 1;
        }

        public void Zeichne()
        {
            foreach (Ziegel ziegel in listZiegels)
            {
                ziegel.Zeichne();
            }
        }
    }
}
