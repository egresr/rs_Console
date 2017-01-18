using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class MauerAussen
    {
        Position position;
        Richtung richtung;
        int laenge;
        ConsoleColor ziegelFarbe;
        char ziegelZeichen;

        List<Ziegel> listZiegelFuerMauer;

        public MauerAussen(Position position, Richtung richtung, int laenge, ConsoleColor ziegelFarbe, char ziegelZeichen)
        {
            this.position = new Position(position);
            this.richtung = richtung;
            this.laenge = laenge;
            this.ziegelFarbe = ziegelFarbe;
            this.ziegelZeichen = ziegelZeichen;

            ErzeugeListZiegelFuerMauer();
        }

        private void ErzeugeListZiegelFuerMauer()
        {
            listZiegelFuerMauer = new List<Ziegel>();

            for (int i = 0; i < laenge; i++)
            {
                listZiegelFuerMauer.Add(new Ziegel(position, ziegelZeichen, ziegelFarbe));
                BestimmeNextZiegelPosition(richtung);
            }
        }

        private void BestimmeNextZiegelPosition(Richtung richtung)
        {
            if (richtung == Richtung.nachLinks)
                position.KoordinateX -= 1;
            if (richtung == Richtung.nachRechts)
                position.KoordinateX += 1;
            if (richtung == Richtung.nachOben)
                position.KoordinateY -= 1;
            if (richtung == Richtung.nachUnten)
                position.KoordinateY += 1;
        }

        public void Zeichne()
        {
            foreach (Ziegel ziegel in listZiegelFuerMauer)
            {
                ziegel.Zeichne();
            }
        }
    }
}
