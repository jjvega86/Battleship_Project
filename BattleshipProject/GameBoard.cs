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

        public string[,] Board;

        public GameBoard()
        {
            Board = new string[21, 21]; // [rows, columns]
            InitializeBoardValues();
            InitializeBoardLabelValues();
            
        }

        public virtual void InitializeBoardLabelValues()
        {
            char letter = 'A';

            // The "0,0" index should not print any value
            for (int i = 0; i < Board.GetLength(1); i++)// sets column labels 1-20
            {
                Board[0, i] = string.Concat(i + " ");

            }

            for (int i = 1; i < Board.GetLength(0); i++)// sets row labels A-U
            {
                Board[i, 0] = string.Concat(letter + " ");
                letter++;
            }
        }

        public virtual void InitializeBoardValues()
        {
            for (int row = 0; row < Board.GetLength(0); row++)
            {
                for (int column = 0; column < Board.GetLength(1); column++)
                {
                    Board[row, column] = "- ";

                }
            }
        }

        public virtual void PrintBoard()
        {
            for (int row = 0; row < Board.GetLength(0); row++)
            {
                for (int column = 0; column < Board.GetLength(1); column++)
                {
                    Console.Write(Board[row, column]);

                }
                Console.WriteLine("");
            }

        }
        // forces child classes to write their own unique printboard logic
        // ActiveBoard should show everything, StatusBoard should show everything minus ship locations




    }
}
