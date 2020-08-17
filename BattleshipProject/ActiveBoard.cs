using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class ActiveBoard : GameBoard
    {
        // Full board with ship locations and hit attempts 


        // member variables (DOES HAVE)

        // constructor

        // member methods (CAN DO)

        public override void PrintBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(board[i,i]);
            }

        }

    }
}
