using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    abstract class Player
    {
        public int playerChoice;
        public int score;
        

        public abstract void ChooseGesture();

    }

}
