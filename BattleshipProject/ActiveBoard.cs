using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class ActiveBoard : GameBoard
    {
        public override void PrintBoard()
        {            
            for (int row = 0; row < Board.GetLength(0); row++)
            {
                for (int column = 0; column < Board.GetLength(1); column++)
                {
                    Console.WriteLine($"{Board[row, column]}\n");

                }
            }

        }

    }
}
