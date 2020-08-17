using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    public abstract class Ship
    {
        public string[] shipSpaces;
        public bool destroyedStatus;

        public Ship()
        {
            shipSpaces = new string[0];
            destroyedStatus = false;
        }

    }
}
