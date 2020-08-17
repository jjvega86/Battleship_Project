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
        // fleet status. Once a player's fleet is empty, game is over
        // could create a counter of some type and boolean check if equals zero

        public Game()
        {
            // method will initialize values here
        }

        public void RunGame()
        {
            // orchestrator method, all other Game methods will go here
        }

        public void InitializeValues()
        {

        }

        public void GameIntroduction()
        {
            // welcome and rules here
        }
    }
}
