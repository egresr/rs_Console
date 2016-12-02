using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnee
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAnzahl = 100;

            Console.CursorVisible = false;
            Random random = new Random();
            int windStaerke = random.Next(-5,5);

            Schneewolke schneewolke1 = new Schneewolke(random.Next(maxAnzahl), '1');
            Schneewolke schneewolke2 = new Schneewolke(random.Next(maxAnzahl), '2');
            Schneewolke schneewolke3 = new Schneewolke(random.Next(maxAnzahl), '3');

            Schneewolke schneewolke4 = new Schneewolke(160, '4');
            Schneewolke schneewolke5 = new Schneewolke(320, '5');
            Schneewolke schneewolke6 = new Schneewolke(20, '6');
            Schneewolke schneewolke7 = new Schneewolke(160, '7');


            //Console.Write("\tSchneewolke_2 : {0}", schneewolke2.SchneeflockenCount());
            //Console.Write("\tSchneewolke_3 : {0}", schneewolke3.SchneeflockenCount());

            for (int i = 0; i  < 500; i++)
            {
                System.Threading.Thread.Sleep(1000);

                Console.CursorVisible = false;
                //schneewolke1.Bewege(new Wind(windStaerke));

                Console.SetCursorPosition(1, Console.WindowHeight - 3);

                Console.CursorVisible = true;
                Console.Write("i : {0}", i);

                Console.SetCursorPosition(1, Console.WindowHeight - 1);
                Console.Write("Schneewolke_1 : {0}", schneewolke1.SchneeflockenCount());
            }


            Console.ReadLine();




        }
    }
}
