using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkplatz
{
    class InfoTafel
    {
        Parkplatzgelaende parkplatzgelaende;
        public InfoTafel(Parkplatzgelaende parkplatzgelaende)
        {
            this.parkplatzgelaende = parkplatzgelaende;
        }

        public static void Einblenden(Parkplatzgelaende parkplatzgelaende)
        {
            Console.SetCursorPosition(1, 1);
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write(parkplatzgelaende.PositionEckeLinksOben.KoordinateX + "/" + parkplatzgelaende.PositionEckeLinksOben.KoordinateY);
            Console.Write("\t" + parkplatzgelaende.PositionEckeRechtsOben.KoordinateX + "/" + parkplatzgelaende.PositionEckeRechtsOben.KoordinateY);
            Console.Write("\t" + parkplatzgelaende.PositionEckeLinksUnten.KoordinateX + "/" + parkplatzgelaende.PositionEckeLinksUnten.KoordinateY);
            Console.Write("\t" + parkplatzgelaende.PositionEckeRechtsUnten.KoordinateX + "/" + parkplatzgelaende.PositionEckeRechtsUnten.KoordinateY);
        }
    }
}
