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
        public string name;
        

        public abstract void ChooseGesture();

    }

}
