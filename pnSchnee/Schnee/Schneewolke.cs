using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnee
{
    class Schneewolke
    {
        int schneeflockenAnzahl;
        char symbol;
        List<Schneeflocke> schneeflocken;


        int breite, breiteMin = 4, breiteMax = 50; //Schneewolke Breite
        int hohe, hoheMin = 2, hoheMax = 5; //Schneewolke Hohe
        int xPosition, xPositionMax, yPosition, yPositionMax; //Schneewolke Koordinaten

        Random random = new Random();


        public Schneewolke(int schneeflockenAnzahl, char symbol)
        {
            this.schneeflockenAnzahl = schneeflockenAnzahl;
            this.symbol = symbol;
            BestimmeBreiteHohe();
            BestimmePosition();
            FulleMitSchneeflocken();
            Zeichne();
        }



        private void BestimmeBreiteHohe()
        {
            breite = random.Next(breiteMin, breiteMax);
            hohe = random.Next(hoheMin, hoheMax);
        }

        private void BestimmePosition()
        {
            xPositionMax = random.Next(Console.WindowWidth - breite);
            yPositionMax = random.Next(5);

            xPosition = random.Next(xPositionMax);
            yPosition = random.Next(yPositionMax);
        }

        private void FulleMitSchneeflocken()
        {
            schneeflocken = new List<Schneeflocke>();
            for (int i = 0; i < schneeflockenAnzahl; i++)
            {
                int positionX = random.Next(xPosition, xPosition + breite);
                int positionY = random.Next(yPosition, yPosition + hohe);
                schneeflocken.Add(new Schneeflocke(positionX, positionY, symbol));
            }
        }

        public int SchneeflockenCount()
        {
            return schneeflocken.Count;
        }

        public void Zeichne()
        {
            foreach (Schneeflocke eineSchneeflocke in schneeflocken)
            {
                eineSchneeflocke.Zeichne();
            }
        }





        //public void GetNextXPosition(Wind wind)
        //{
        //    if (wind.Geschwindigkeit < 0)
        //    {
        //        //ToDo
        //    }
        //    else if (wind.Geschwindigkeit > 0)
        //    {
        //        //ToDo
        //    }
        //    else
        //    {
        //        //ToDo
        //    }
        //}

        //public void Bewege(Wind wind)
        //{
        //    GetNextXPosition(wind);
        //    BestimmeBreiteHohe();
        //    BestimmePosition();
        //    Console.Clear();
        //    FulleMitSchneeflocken();
        //    Zeichne();

        //}

    }
}
