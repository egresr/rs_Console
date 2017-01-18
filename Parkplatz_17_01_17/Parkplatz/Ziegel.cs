using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class Ziegel
    {
        Position position;
        char ziegelZeichen;
        ConsoleColor ziegelFarbe;

        public Ziegel(Position position, char ziegelZeichen, ConsoleColor ziegelFarbe)
        {
            this.position = new Position(position);
            this.ziegelZeichen = ziegelZeichen;
            this.ziegelFarbe = ziegelFarbe;
        }

        public void Zeichne()
        {
            Console.SetCursorPosition(position.KoordinateX, position.KoordinateY);
            Console.ForegroundColor = ziegelFarbe;
            Console.Write(ziegelZeichen);
        }
    }
}
