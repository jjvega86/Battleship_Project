using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class Submarine : Ship
    {
        public Submarine()
        {
            Name = "Submarine";
            ShipSpaces = new string[] { "> ", "> ", "> " };
        }
    }
}
