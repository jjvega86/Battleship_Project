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
        public int OrientationCode; // 0 is default, 1 is horizontal, 2 is vertical
        public bool DestroyedStatus;

        public Ship()
        {
            Name = "Default";
            ShipSpaces = new string[] { "> " };
            DestroyedStatus = false;
            OrientationCode = 0;
        }

    }
}
