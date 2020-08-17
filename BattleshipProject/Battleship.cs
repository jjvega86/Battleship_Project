using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class Battleship : Ship
    {
        public Battleship()
        {
            Name = "Battleship";
            ShipSpaces = new string[] { "X ", "X ", "X ", "X " };
        }
    }
}
