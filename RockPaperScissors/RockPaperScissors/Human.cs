﻿using System;
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
            Console.WriteLine("Please choose from the following: \n 1)rock, \n 2)paper, \n 3)scissors, \n 4)lizard, \n 5)spock ");
            playerChoice = int.Parse(Console.ReadLine());
            switch (playerChoice) 
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid Choice, choose 1 -5 only.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
