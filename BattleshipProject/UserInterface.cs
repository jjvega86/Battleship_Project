using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipProject
{
    class UserInterface
    {
        //handles all user input and prompts

        public static string GetUserInputString(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;
        }

        public static int GetUserInputInt(string prompt)
        {
            Console.WriteLine(prompt);
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
