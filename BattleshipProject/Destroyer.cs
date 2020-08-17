using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class Destroyer : Ship
    {
        public Destroyer()
        {
            Name = "Destroyer";
            ShipSpaces = new string[] { "X ", "X " };
        }
    }
}
