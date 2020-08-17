using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class Player
    {
        public int Score;
        public string Name;
        public ActiveBoard activeboard;
        public StatusBoard statusboard;
        public Fleet fleet;

        // constructor
        public Player()
        {
            Name = "Player";
            Score = 0;
        }

        public void SetPlayerName()
        {
            Console.WriteLine("Please enter your name!");
            Name = Console.ReadLine();
        }

        // member methods (CAN DO)
        //  choose location to hit
        //  see own board
        //  check other player's board for hits and destroyed ships
        //  move ships around board without overlapping 
    }
}
