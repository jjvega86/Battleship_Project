using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class AircraftCarrier : Ship
    {
        public AircraftCarrier()
        {
            Name = "Aircraft Carrier";
            ShipSpaces = new string[] { "> ", "> ", "> ", "> ", "> " };

        }
    }
}
