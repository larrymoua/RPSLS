using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        Random rnd;
        public Computer()
        {
            
            name = "CpU";
            rnd = new Random();
           
        }//constructor
        public override void ChooseGesture()
        {
            int indexRandom;
            indexRandom = rnd.Next(gestureOptions.Count);
            gesture = gestureOptions[indexRandom];
        }
    }//end computer
}//end namespace
