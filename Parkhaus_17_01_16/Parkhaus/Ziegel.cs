using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Ziegel
    {
        Position position;
        char zeichen = '▓';
        ConsoleColor farbe;

        public Position Position { get { return position; } }
        public char Zeichen { get { return zeichen; } }
        public ConsoleColor Farbe { get { return farbe; } set { farbe = value; } }


        public Ziegel(Position position, ConsoleColor farbe)
        {
            this.position = position;
            this.farbe = farbe;
        }


        public void Zeichne()
        {
            Console.SetCursorPosition(position.KoordinateX, position.KoordinateY);
            Console.ForegroundColor = farbe;
            Console.Write(zeichen);
        }
    }
}
