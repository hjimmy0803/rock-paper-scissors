using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        public List<string> GestureList;
        public Player p1;
        public Player p2;
        public int count = 1;

        public Game()
        {
            
        }

        public void GetGestureList() {
            GestureList = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            foreach (string gesture in GestureList) {
                Console.WriteLine(count++ + "" + "" + gesture);
            }
            Console.ReadLine();
        }

        public void RunGame()
        {
            string WelcomeMessage = " Welcome to the game:Rock,Paper,Scissors,Lizard,Spock! ";
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine("These are the rules to the game: \n Scissors cuts paper, \n paper covers rock, \n rock crushes lizard,\n lizard poisons Spock, \n Spock smashes scissors, \n scissors decapitates lizard, \n lizard eats paper, \n paper disproves Spock, \n Spock vaporizes rock, \n and of course rock crushes scissors.");
            Console.WriteLine("How man players will there be ? Please choose (1) or (2) players ");
            
        }
    }
}
