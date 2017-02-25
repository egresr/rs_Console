using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KassenAutomat_M005.ModulBezahlVerfahren
{
    class Display
    {
        int positionX = 35;
        int positionY = 5;

        public string EingangString { get; set; }

        public void Einschalten()
        {
            Console.Clear();

            Console.SetCursorPosition(positionX + 1, positionY);
            Console.Write("{0}", DateTime.Now.ToString("HH:mm \t\t dd MMMM yyyy"));

            Console.SetCursorPosition(positionX, positionY + 1);
            Console.Write(new string('=', 38));

            Console.SetCursorPosition(positionX + 1, positionY + 3);
            Console.Write("Betrag \t : \t\t{0}€", BezahlVerfahren.AktuelleKosten);

            Console.SetCursorPosition(positionX, positionY + 5);
            Console.Write(new string('-', 38));

            Console.SetCursorPosition(positionX + 1, positionY + 7);
            Console.Write("Bezahlt \t : \t\t{0}€", BezahlVerfahren.NennWert);

            Console.SetCursorPosition(positionX, positionY + 9);
            Console.Write(new string('-', 38));

            Console.SetCursorPosition(positionX + 1, positionY + 11);
            Console.Write("Restbetrag \t : \t\t{0}€", BezahlVerfahren.AktuelleKosten);

            Console.SetCursorPosition(positionX, positionY + 13);
            Console.Write(new string('=', 38));

            Console.SetCursorPosition(positionX + 1, positionY + 15);
            Console.Write("Betrag eingeben (b/m) : ");

            Console.SetCursorPosition(29 + positionX, positionY + 15);

            Console.CursorVisible = true;
            EingangString = null;
            EingangString = Console.ReadLine();
            Console.CursorVisible = false;
        }
    }
}
