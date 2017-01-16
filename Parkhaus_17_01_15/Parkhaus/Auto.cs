using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Auto
    {
        ConsoleColor farbe;
        string kennzeichen;
        char zeichen = '█';
        Position positionEinfahrtbereich;
        Position positionParkbereich;
        int breite = 3;
        int laenge = 2;

        List<Position> listPositionenEinfahrtbereich;
        List<Position> listPositionenParkbereich;

        public ConsoleColor Farbe { get { return farbe; } }
        public string Kennzeichen { get { return kennzeichen; } }
        public int KoordinateXEinfahrtbereich { get { return positionEinfahrtbereich.KoordinateX; } set { positionEinfahrtbereich.KoordinateX = value; } }
        public int KoordinateYEinfahrtbereich { get { return positionEinfahrtbereich.KoordinateY; } set { positionEinfahrtbereich.KoordinateY = value; } }
        public int KoordinateXParkbereich { get { return positionParkbereich.KoordinateX; } set { positionParkbereich.KoordinateX = value; } }
        public int KoordinateYParkbereich { get { return positionParkbereich.KoordinateY; } set { positionParkbereich.KoordinateY = value; } }


        public void Parken(Parkplatz parkplatz)
        {
            ErzeugeListPosition_Parkbereich(parkplatz);
            ZeichneParkplatzBereich();
        }

        public Auto(string kennzeichen, ConsoleColor farbe, Einfahrt einfahrt)
        {
            this.kennzeichen = kennzeichen;
            this.farbe = farbe;

            positionEinfahrtbereich = new Position(einfahrt.KoordinateX, einfahrt.KoordinateY);

            ErzeugeListPosition_Einfahrtbereich();
            ZeichneEinfahrtBereich();
        }

        private void ErzeugeListPosition_Einfahrtbereich()
        {
            listPositionenEinfahrtbereich = new List<Position>();

            for (int i = 0; i < laenge; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    listPositionenEinfahrtbereich.Add(new Position(positionEinfahrtbereich.KoordinateX + j + 2, positionEinfahrtbereich.KoordinateY + i + 1));
                }
            }
        }

        private void ErzeugeListPosition_Parkbereich(Parkplatz parkplatz)
        {
            positionParkbereich = new Position(parkplatz.KoordinateX, parkplatz.KoordinateY);
            listPositionenParkbereich = new List<Position>();
            for (int i = 0; i < laenge; i++)
            {
                for (int j = 0; j < breite; j++)
                {
                    listPositionenParkbereich.Add(new Position(positionParkbereich.KoordinateX + j, positionParkbereich.KoordinateY + i));
                }
            }
        }
        public void ZeichneEinfahrtBereich()
        {
            foreach (Position position in listPositionenEinfahrtbereich)
            {
                Console.SetCursorPosition(position.KoordinateX, position.KoordinateY);
                Console.ForegroundColor = farbe;
                Console.Write(zeichen);
            }
        }

        public void ZeichneParkplatzBereich()
        {
            foreach (Position position in listPositionenParkbereich)
            {
                Console.SetCursorPosition(position.KoordinateX, position.KoordinateY);
                Console.ForegroundColor = farbe;
                Console.Write(zeichen);
            }
        }


    }
}
