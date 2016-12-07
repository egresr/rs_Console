using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalettenSpedition
{
    class Palette
    {
        int id;
        int laenge = 1200; //mm
        int breite = 800; //mm
        int hohe = 144; //mm
        int gewicht = 25; //kg
        
        public int Id { get { return id; } }
        public double Gewicht { get { return gewicht; } }

        public Palette()
        {

        }
    }
}
