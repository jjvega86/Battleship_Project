using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class Game
    {
        public Player Player1;
        public Player Player2;

        public Game()// method will initialize values here for game replay logic

        {
            Player1 = new Player();
            Player2 = new Player();
        }

        public void RunGame()// orchestrator method, all other Game methods will go here

        {
            Player1.VisibleBoard.PrintBoard();
            Player1.SetPlayerName();
            Player1.SetShipLocations();
            Player1.VisibleBoard.PrintBoard();
            Player1.ChooseHitLocation(Player1.HiddenBoard);
            Player1.VisibleBoard.PrintBoard();


        }

        public void InitializeValues()// initialize constructor to reset member variable values
        {

        }

        public void GameIntroduction()
        {
            // welcome and rules here
        }


        public void DeclareWinner()
        {

        }

        public void ReplayGame()
        {

        }
    }
}
