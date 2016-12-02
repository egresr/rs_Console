using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnee
{
    class Schneit
    {
        int positionX;
        int positionY;
        Schneeflocke schneeflocke;
        List<Schneeflocke> listSchneeflocken;
        Random random = new Random();

        public Schneit()
        {
            ErzeugeSchneeWolke();
            Niederschalg();
        }

        public void ErzeugeSchneeWolke()
        {
            listSchneeflocken = new List<Schneeflocke>();
            for (int i = 0; i < 50; i++)
            {
                positionX = random.Next(Console.WindowWidth);
                positionY = random.Next(0, 5);
                listSchneeflocken.Add(new Schneeflocke(positionX, positionY, 'y'));
            }
        }

        public void Niederschalg()
        {
            foreach(Schneeflocke schneeflocke in listSchneeflocken)
            {
                schneeflocke.Zeichne();
            }            
        }
        

        
    }
}
