using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    public abstract class GameBoard
    {
        // 2d array 21 * 21
     

        public string[,] Board;

        public GameBoard()
        {
            Board = new string[21, 21]; // [rows, columns]
            InitializeBoardValues();
            InitializeBoardLabelValues();
            
        }

        public virtual void InitializeBoardLabelValues()
        {

            for (int i = 0; i < Board.GetLength(1); i++)// sets column and row labels 1-20
            {
                Board[0, i] = string.Concat(i + " ");
                Board[i, 0] = string.Concat(i + " ");
            }
        }

        public virtual void InitializeBoardValues()
        {
            for (int row = 0; row < Board.GetLength(0); row++)
            {
                for (int column = 0; column < Board.GetLength(1); column++)
                {
                    Board[row, column] = "-" + " ";

                }
            }
        }

        public virtual void PrintBoard()
        {
            // i want to print the entire player board on the console
            // i want the entire first row to print, then the next row, and so on
            // the final result will be a 20 by 20 grid in alignment so the player can select
            // hit locations and ship locations

            int row = 0;

            while (row < Board.GetLength(0))
            {
                for (int column = 0; column < Board.GetLength(0); column++)
                {
                    Console.Write(Board[row, column]);

                }
                row++;
                Console.WriteLine();
            }

            
        }
        




    }
}
