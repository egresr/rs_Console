using Schnee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnee
{
    class Niederschlag
    {
        Schneewolke wolke;
        Random random = new Random();

        public Niederschlag(Schneewolke wolke)
        {
            this.wolke = wolke;
        }

        public void Schneit()
        {
            for(int i = 0; i < Console.WindowHeight - wolke.YPosition; i++)
            {
                for (int j = 0; j < wolke.schneeflocken.Count; j++)
                {
                    wolke.schneeflocken[j].Fallen();
                    wolke.Zeichne();




                    System.Threading.Thread.Sleep(10);
                }
            }
           
        }
    }
}
