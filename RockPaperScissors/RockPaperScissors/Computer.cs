using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        

       
        
        public override void ChooseGesture()
        {
            Random random = new Random();
            playerChoice = random.Next(1, 5);
        }
    }
}
