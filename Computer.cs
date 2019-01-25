using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    { 

        public Computer()
        {
            roundsWon = 0;
            name = "cPU";
        }//constructor
        public override void GestureChosen()
        {
            Random rnd = new Random(); 
            int i;
            string [] gestureOptions = new string[5] {"ROCK", "PAPER" ,"SCISSORS","LIZARD", "SPOCK" };
            i = rnd.Next(4);
          
            gesture = gestureOptions[i];
        }
    }//end computer
}//end namespace
