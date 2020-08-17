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
        public int rowSelection;
        public int columnSelection;

        public Player()
        {
            Name = "Player";
            Score = 0;
            ActiveBoard = new ActiveBoard();
            StatusBoard = new StatusBoard();
            armada = new ShipFleet();
            rowSelection = 0;
            columnSelection = 0;
        }

        public void SetShipLocations()
        {
            for (int i = 0; i < armada.Fleet.Length; i++)
            {
                Console.WriteLine($"Please pick a spot for your {armada.Fleet[i].Name}!");
                Console.WriteLine("Pick row:");
                rowSelection = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick column:");
                columnSelection = int.Parse(Console.ReadLine());
                ValidateShipLocation(rowSelection, columnSelection);
                ActiveBoard.Board[rowSelection, columnSelection] = string.Concat(armada.Fleet[i].ShipSpaces);

            }
        }

        public void ValidateShipLocation(int row, int column)
        {
            if (ActiveBoard.Board[row,column] != "- ")
            {
                Console.WriteLine("Please try again!");
                Console.WriteLine("Pick row:");
                rowSelection = int.Parse(Console.ReadLine());
                Console.WriteLine("Pick column:");
                columnSelection = int.Parse(Console.ReadLine());
                ValidateShipLocation(rowSelection, columnSelection);

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
