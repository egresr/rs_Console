using Kassenautomat.Zahlung;
using System;

namespace Kassenautomat
{
    class Program
    {
        static void Main(string[] args)
        {
            double parkGebuer = 120.34;

            Zahlungsverfahren zahlung = new Zahlungsverfahren(parkGebuer);


          //  Console.ReadKey();
        }
    }
}
