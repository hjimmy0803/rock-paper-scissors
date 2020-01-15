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

        public void GetGestureList()
        {
            GestureList = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
            foreach (string gesture in GestureList)
            {
                Console.WriteLine(count++ + "" + "" + gesture);
            }
            Console.ReadLine();
        }

        public void InitGame()
        {
            string WelcomeMessage = " Welcome to the game:Rock,Paper,Scissors,Lizard,Spock! ";
            Console.WriteLine(WelcomeMessage);
            Console.WriteLine("These are the rules to the game: \n Scissors cuts paper, \n paper covers rock, \n rock crushes lizard,\n lizard poisons Spock, \n Spock smashes scissors, \n scissors decapitates lizard, \n lizard eats paper, \n paper disproves Spock, \n Spock vaporizes rock, \n and of course rock crushes scissors.");
            Console.WriteLine("How man players will there be ? Please choose (1) or (2) players ");

            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.WriteLine();
                p1 = new Human();
                p2 = new Computer();
                //p1.ChooseGesture();
                //p2.ChooseGesture();
                p2.name = "Jarvis";

            }
            else if (userChoice == 2)
            {
                p1 = new Human();
                p2 = new Human();
                //p1.ChooseGesture();
                //p2.ChooseGesture();
            }
            else
            {
                Console.WriteLine("Sorry,but your only options are 1 or 2");
                Console.ReadLine();
                InitGame();
            }

        }

        public void RunGame()
        {
            while (p1.score < 2 && p2.score < 2)
            {
                //Console.WriteLine("Player 1, choose from these following options: \n 1.Rock \n 2.Paper \n 3.Scissors \n 4.Lizard \n 5.Spock");
                //int player1Choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(player1Choice);
                p1.ChooseGesture();
                p2.ChooseGesture();

                //Console.WriteLine("Player 2, choose from these following options: \n 1.Rock \n 2.Paper \n 3.Scissors \n 4.Lizard \n 5.Spock");
                //int player2Choice = int.Parse(Console.ReadLine());
                //Console.WriteLine(player2Choice);

                Console.WriteLine($"p1: {p1.playerChoice} p2: {p2.playerChoice}");
                Console.ReadLine();

                if (p1.playerChoice == p2.playerChoice)
                {
                    Console.WriteLine("Draw!! Try again.");
                    Console.ReadLine();
                }
                else if (p1.playerChoice == 1 && (p2.playerChoice == 3 || p2.playerChoice == 5))
                {
                    p1.score++;
                    Console.WriteLine($"Player one {p1.score} score");
                    Console.ReadLine();
                }
                else if (p1.playerChoice == 3 && (p2.playerChoice == 2 || p2.playerChoice == 5))
                {
                    p1.score++;
                    Console.WriteLine($"Player one {p1.score} score");
                    Console.ReadLine();
                }
                else if (p1.playerChoice == 2 && (p2.playerChoice == 1 || p2.playerChoice == 4))
                {
                    p1.score++;
                    Console.WriteLine($"Player one {p1.score} score");
                    Console.ReadLine();
                }
                else if (p1.playerChoice == 4 && (p2.playerChoice == 3 || p2.playerChoice == 1))
                {
                    p1.score++;
                    Console.WriteLine($"Player one {p1.score} score");
                    Console.ReadLine();
                }
                else if (p1.playerChoice == 5 && (p2.playerChoice == 4 || p2.playerChoice == 2))
                {
                    p1.score++;
                    Console.WriteLine($"Player one {p1.score} score");
                    Console.ReadLine();
                }
                else
                {
                    p2.score++;
                    Console.WriteLine($"Player two {p2.score} score");
                    Console.ReadLine();
                }
            }
        }
    }
}
