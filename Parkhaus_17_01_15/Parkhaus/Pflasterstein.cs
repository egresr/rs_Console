using System;

namespace Parkhaus
{
    class Pflasterstein
    {
        Position position;
        char zeichen = '░';
        //char zeichen = '▓';
        //ConsoleColor farbe = ConsoleColor.Blue;
        ConsoleColor farbe = ConsoleColor.DarkYellow;
        public Pflasterstein(int koordinateX, int koordinateY)
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