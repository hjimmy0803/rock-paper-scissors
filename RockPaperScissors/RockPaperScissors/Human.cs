using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
 
    class Human:Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("Player 1 Please choose from the following: \n 1)rock, \n 2)paper, \n 3)scissors, \n 4) lizard, \n 5)spock ");
            playerChoice = int.Parse(Console.ReadLine());
        }
    }
}
