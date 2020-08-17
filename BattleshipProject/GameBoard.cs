using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    public abstract class GameBoard
    {
        // member variables (DOES HAVE)
        // 2d array 21 * 21
        //  includes both labels A-J, 1-10 and the game spaces themselves

        string[,] board;

        public GameBoard()
        {
            board = new string[21, 21];
            InitializeBoardValues();
        }

        public virtual void InitializeBoardValues()
        {
            for (int i = 1; i < 11; i++)
            {
                board[i, i] = "-";

            }
        }
        // constructor
        //  sets default values equal to "O" or a placeholder value
        //  sets lables equal to A-J (horizontal) and 1-10 (vertical)

        // member methods (CAN DO)
        //  Print the current board
        //  Print the other player's board (attempted hits, hits, destroyed ships)
    }
}
