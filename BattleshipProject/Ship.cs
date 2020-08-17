using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    public abstract class Ship
    {
        public string[] ShipSpaces;
        public bool DestroyedStatus;

        public Ship()
        {
            ShipSpaces = new string[0];
            DestroyedStatus = false;
        }

    }
}
