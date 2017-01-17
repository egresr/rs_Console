using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkhaus
{
    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(0, 0);

            Wand wand = new Wand(50, Richtung.nachRechts, ConsoleColor.Red, position);
            wand.Zeichne();


            Console.ReadLine();
        }
    }
}
