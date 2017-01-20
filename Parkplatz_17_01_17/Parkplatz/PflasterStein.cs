using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class PflasterStein
    {
        Position position;
        char ziegelpflasterSteinZeichenZeichen;
        ConsoleColor pflasterSteinFarbe;

        public PflasterStein(Position position, char ziegelpflasterSteinZeichen, ConsoleColor pflasterSteinFarbe)
        {
            this.position = new Position(position);
            this.ziegelpflasterSteinZeichenZeichen = ziegelpflasterSteinZeichen;
            this.pflasterSteinFarbe = pflasterSteinFarbe;
        }

        public void Zeichne()
        {
            Console.SetCursorPosition(position.KoordinateX, position.KoordinateY);
            Console.ForegroundColor = pflasterSteinFarbe;
            Console.Write(ziegelpflasterSteinZeichenZeichen);
        }
    }
}
