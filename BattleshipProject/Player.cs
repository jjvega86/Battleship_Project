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
                rowSelection = UserInterface.GetUserInputInt($"Pick a row for your {armada.Fleet[i].Name}!\n");
                columnSelection = UserInterface.GetUserInputInt($"Pick a column for your {armada.Fleet[i].Name}!\n");                          
                ValidateShipLocation(rowSelection, columnSelection);
                ActiveBoard.Board[rowSelection, columnSelection] = string.Concat(armada.Fleet[i].ShipSpaces);

            }
        }

        public void SetShipDirection()
        {
            //use to set vertical or horizontal orientation of ship
        }

        public void ValidateShipLocation(int row, int column)
        { 
            if (ActiveBoard.Board[row,column] != "- ")
            {
                rowSelection = UserInterface.GetUserInputInt("Invalid selection. Please pick a row:\n");
                columnSelection = UserInterface.GetUserInputInt("Please pick a column:\n");
                ValidateShipLocation(rowSelection, columnSelection);

            }

        }

        public void SetPlayerName()
        {
            Name = UserInterface.GetUserInputString("Please enter your name!\n");
        }

        public void ChooseHitLocation(ActiveBoard activeBoard)
        {
            rowSelection = UserInterface.GetUserInputInt("Pick the row of your hit!\n");
            columnSelection = UserInterface.GetUserInputInt("Pick the column of your hit!\n");
            activeBoard.Board[rowSelection, columnSelection] = "X";

        }

        
       
    }
}
