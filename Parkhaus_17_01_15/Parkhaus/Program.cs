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
            Wand wandHorizontal = new Wand(3, 1, 150, Richtung.nachRechts);
            Wand wandHorizontal1 = new Wand(3, 1, 30, Richtung.nachUnten);
            wandHorizontal.Zeichne();
            wandHorizontal1.Zeichne();

            Console.ReadLine();
        }
    }
}

//////Mauerstein mauerstein = new Mauerstein(1, 1);
//////Mauerstein mauerstein1 = new Mauerstein(2, 1);
//////Mauerstein mauerstein2 = new Mauerstein(1, 2);
//////Mauerstein mauerstein3 = new Mauerstein(2, 2);
//////Mauerstein mauerstein4 = new Mauerstein(1, 3);
//////Mauerstein mauerstein5 = new Mauerstein(2, 3);

//////Mauerstein mauerstein6 = new Mauerstein(3, 1);
//////Mauerstein mauerstein7 = new Mauerstein(4, 1);
//////Mauerstein mauerstein8 = new Mauerstein(5, 1);
//////Mauerstein mauerstein9 = new Mauerstein(6, 1);
//////Mauerstein mauerstein10 = new Mauerstein(7, 1);
//////Mauerstein mauerstein11 = new Mauerstein(8, 1);

//////mauerstein.Zeichne();
//////mauerstein1.Zeichne();
//////mauerstein2.Zeichne();
//////mauerstein3.Zeichne();
//////mauerstein4.Zeichne();
//////mauerstein5.Zeichne();

//////mauerstein6.Zeichne();
//////mauerstein7.Zeichne();
//////mauerstein8.Zeichne();
//////mauerstein9.Zeichne();
//////mauerstein10.Zeichne();
//////mauerstein11.Zeichne();