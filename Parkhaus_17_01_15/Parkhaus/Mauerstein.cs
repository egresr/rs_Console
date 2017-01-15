using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Mauerstein
    {
        //char zeichen = '▓';
        char zeichen = '█';
        ConsoleColor farbe = ConsoleColor.DarkRed;
        Position position;

        public int KoordinateX { get { return position.KoordinateX; } set { position.KoordinateX = value; } }
        public int KoordinateY { get { return position.KoordinateY; } set { position.KoordinateY = value; } }
        public char Zeichen { get { return zeichen; } set { zeichen = value; } }

        public Mauerstein(int koordinateX, int koordinateY)
        {
            position = new Position(koordinateX, koordinateY);
        }

        public void Zeichne()
        {
            Console.SetCursorPosition(position.KoordinateX, position.KoordinateY);
            Console.ForegroundColor = farbe;
            Console.Write(zeichen);
        }
    }
}
