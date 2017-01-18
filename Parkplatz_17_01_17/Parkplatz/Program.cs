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
            InfoTafel infotafel = new InfoTafel(parkplatzgelaende);
           





            Console.ReadLine();
        }
    }
}
 