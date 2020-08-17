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

        public string[,] board;

        public GameBoard()
        {
            board = new string[21, 21]; // [rows, columns]
            InitializeBoardLabelValues();
            InitializeBoardValues();
        }

        public virtual void InitializeBoardLabelValues()
        {
            // The "0,0" index should not print any value
            for (int i = 1; i < 11; i++)// sets column labels 1-10
            {
                board[0, i] = string.Concat(i);

            }

            for (int i = 1; i < 11; i++)// sets row labels A-J
            {
                char letter = 'A';
                board[i, 0] = string.Concat(letter);
                letter++;

            }
        }

        public virtual void InitializeBoardValues()
        {
            for (int i = 1; i < 11; i++)
            {
                board[i, i] = "-";

            }
        }

        public abstract void PrintBoard();
        // forces child classes to write their own unique printboard logic
        // ActiveBoard should print everything, StatusBoard should print everything minus ship locations
      
       

       
    }
}
