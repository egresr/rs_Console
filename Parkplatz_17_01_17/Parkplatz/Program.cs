using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class Program
    {
        static void Main(string[] args)
        {
            Parkplatzgelaende parkplatzgelaende = new Parkplatzgelaende(1, 1, 3, 5);
            //Parkplatzgelaende parkplatzgelaende = new Parkplatzgelaende(0, 0, 0, 0);
            //InfoTafel infotafel = new InfoTafel(parkplatzgelaende);
            InfoTafel.Einblenden(parkplatzgelaende);


            ////////    ToDo ---  ein Parkplatz erzeugen

            Position p1 = new Position(3, 5);
            Parkplatz parkplatz1 = new Parkplatz(p1, ConsoleColor.Gray, '▒');
            parkplatz1.Zeichne();

            Position p2 = new Position(9, 5);
            Parkplatz parkplatz2 = new Parkplatz(p2, ConsoleColor.Gray, '▒');
            parkplatz2.Zeichne();

            Position p3 = new Position(9, 12);
            Parkplatz parkplatz3 = new Parkplatz(p3, ConsoleColor.Gray, '▒');
            parkplatz3.Zeichne();

            Position p4 = new Position(3, 5);
            Parkplatz parkplatz4 = new Parkplatz(p4, ConsoleColor.Gray, '▒');
            parkplatz4.Zeichne();

            Position p5 = new Position(3, 5);
            Parkplatz parkplatz5 = new Parkplatz(p5, ConsoleColor.Gray, '▒');
            parkplatz5.Zeichne();







            Console.ReadLine();
        }
    }
}
 