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
        public ActiveBoard ActiveBoard;
        public StatusBoard StatusBoard;
        public ShipFleet Fleet;

        public Player()
        {
            Name = "Player";
            Score = 0;
            ActiveBoard = new ActiveBoard();
            StatusBoard = new StatusBoard();
            Fleet = new ShipFleet();
        }

        public void SetPlayerName()
        {
            Console.WriteLine("Please enter your name!");
            Name = Console.ReadLine();
        }

        public void ChooseHitLocation()
        {

        }

        public void MoveShip()
        {

        }
       
    }
}
