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
        public ShipFleet armada;

        public Player()
        {
            Name = "Player";
            Score = 0;
            ActiveBoard = new ActiveBoard();
            StatusBoard = new StatusBoard();
            armada = new ShipFleet();
        }

        public void SetShipLocations()
        {
            for (int i = 0; i < armada.Fleet.Length; i++)
            {
                Console.WriteLine($"Please pick a spot for your {armada.Fleet[i].Name}!");
                Console.WriteLine("Pick row:");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick column:");
                int column = int.Parse(Console.ReadLine());
                ActiveBoard.Board[row, column] = armada.Fleet[i];

            }


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
