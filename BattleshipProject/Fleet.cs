using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class Fleet
    {
        public Ship[] fleet;
        public bool emptyStatus; // is the fleet empty? True or false.

        public Fleet()
        {
            fleet = new Ship[] {new Destroyer(), new Submarine(), new Battleship(), new AircraftCarrier()}; 
            emptyStatus = false;
        }
        
    }
}
