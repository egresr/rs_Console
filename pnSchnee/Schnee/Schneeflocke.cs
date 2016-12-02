using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnee
{
    class Schneeflocke
    {
        char symbol;
        int positionX;
        int positionY;

        public Schneeflocke(int positionX, int positionY, char symbol)
        {
            this.positionX = positionX;
            this.positionY = positionY;
            this.symbol = symbol;
        }

        public void Zeichne()
        {
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(symbol);
        }
    }
}
