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
        public HiddenBoard HiddenBoard;
        public VisibleBoard VisibleBoard;
        public ShipFleet armada;
        public int rowSelection;
        public int columnSelection;

        public Player()
        {
            Name = "Player";
            Score = 0;
            HiddenBoard = new HiddenBoard();
            VisibleBoard = new VisibleBoard();
            armada = new ShipFleet();
            rowSelection = 0;
            columnSelection = 0;
        }

        public void SetShipLocations()
        {
            for (int i = 0; i < armada.Fleet.Length; i++)
            {
                rowSelection = UserInterface.GetUserInputInt($"Pick a row for your {armada.Fleet[i].Name}!");
                columnSelection = UserInterface.GetUserInputInt($"Pick a column for your {armada.Fleet[i].Name}!");
                SetShipDirection(armada.Fleet[i]);
                ValidateShipLocation(rowSelection, columnSelection);
                AddShipToBoard(armada.Fleet[i]);
                VisibleBoard.PrintBoard();

            }
        }

        public void AddShipToBoard(Ship ship)
        {
            if (ship.OrientationCode == 1)
            {
                for (int i = 0; i < ship.ShipSize; i++)
                {
                    VisibleBoard.Board[rowSelection, columnSelection] = ">";
                    columnSelection += 1;

                }
            }
            else
            {
                for (int i = 0; i < ship.ShipSize; i++)
                {
                    VisibleBoard.Board[rowSelection, columnSelection] = "^";
                    rowSelection += 1;

                }

            }
        }

        public void SetShipDirection(Ship ship)
        {
            //use to set vertical or horizontal orientation of ship
            ship.OrientationCode = UserInterface.GetUserInputInt("Which direction would you like your ship to go? (1 for horizontal, 2 for vertical)");

        }

        public void ValidateShipLocation(int row, int column)
        { 
            if (VisibleBoard.Board[row,column].Contains(">"))
            {
                rowSelection = UserInterface.GetUserInputInt("Invalid selection. Please pick a row:");
                columnSelection = UserInterface.GetUserInputInt("Please pick a column:");
                ValidateShipLocation(rowSelection, columnSelection);

            }

        }

        public void SetPlayerName()
        {
            Name = UserInterface.GetUserInputString("Please enter your name!\n");
        }

        public void ChooseHitLocation(HiddenBoard activeBoard)
        {
            rowSelection = UserInterface.GetUserInputInt("Pick the row of your hit!\n");
            columnSelection = UserInterface.GetUserInputInt("Pick the column of your hit!\n");
            activeBoard.Board[rowSelection, columnSelection] = "X";

        }

        
       
    }
}
