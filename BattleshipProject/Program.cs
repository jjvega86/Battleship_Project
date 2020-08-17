using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.RunGame();

            //Game Introduction - rules and how to play
            //The game creates two 20 * 20 boards for each player (2 dimensional array)
            //Each player has 4 pieces to place on the game board:
            //              1. Destroyer (2 spaces)
            //              2. Submarine (3 spaces)
            //              3. Battleship (4 spaces)
            //              4. Aircraft Carrier (5 spaces) 
            //              These will be set equal to spaces on the 2 dimensional array board
            //
            //At the start of the game, each player will place their pieces on the board. 
            //Pieces should not overlap.
            //The other player should not be able to see a player's piece locations
            //(Assuming that the other player will move away from the screen on their turn)
            //Each turn, a player will see a print out on the console of known ship locations, misses, etc
            //Player should also be able to view their own board with updated hits and misses
            //The game keeps track of which ships have been destroyed. 
            //The first players to lose all of their ships will win.

            //Classes
            //Game class where all of the main gameplay happens
            //      Member variables: Player player1, Player player2, GameBoard board1, GameBoard board2
            //      Constructor: values set be a method to allow for game looping
            //GameBoard class that blueprints the 2 dimensional array game boards.
            //      How to create the mirror game board that only shows hits and misses?
            //Player class
            //      Member variables: int score, GameBoard, Array that stores game pieces (or multiple arrays stored as list objects
            //in a master array). Then I could add the arrays to the game board and they should automatically fill the right
            //number of spaces depending on their size
            //OR: possible classes for each game piece, based on an abstract parent class GamePiece
            //Could also do parent class for GameBoard, with child classes for StatusBoard and PlayBoard

        }
    }
}
