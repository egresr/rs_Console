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
            Position position = new Position(9, 3);
            Ziegel ziegel = new Ziegel(position, ConsoleColor.DarkGray);
            ziegel.Zeichne();


            Console.ReadLine();
        }
    }
}
