﻿using System;
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
            //Wand wandHorizontal = new Wand(3, 1, 150, Richtung.nachRechts);
            //Wand wandHorizontal1 = new Wand(3, 1, 30, Richtung.nachUnten);
            //wandHorizontal.Zeichne();
            //wandHorizontal1.Zeichne();

            ParkhausRaum parkhausRaum = new ParkhausRaum(2, 1, 1, 1);

            Console.ReadLine();
        }
    }
}