using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class ShipFleet
    {
        public Ship[] Fleet;
        public bool EmptyStatus; // is the fleet empty? True or false.

        public ShipFleet()
        {
            Fleet = new Ship[] {new Destroyer(), new Submarine(), new Battleship(), new AircraftCarrier()}; 
            EmptyStatus = false;
        }
        
    }
}
