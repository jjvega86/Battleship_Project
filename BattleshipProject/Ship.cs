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
        public int ShipSize;
        public int OrientationCode; // 0 is default, 1 is horizontal, 2 is vertical
        public bool DestroyedStatus;

        public Ship()
        {
            Name = "Default";
            ShipSize = 0;
            DestroyedStatus = false;
            OrientationCode = 0;
        }

    }
}
