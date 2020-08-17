using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    public abstract class Ship
    {
        public string Name;
        public string[] ShipSpaces;
        public bool DestroyedStatus;

        public Ship()
        {
            Name = "Default";
            ShipSpaces = new string[] { "X " };
            DestroyedStatus = false;
        }

    }
}
