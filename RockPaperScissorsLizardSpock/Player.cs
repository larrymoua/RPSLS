using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        public string name;
        public int roundsWon;
        public string gesture;

        public Player()
        {

        }//end Players
        public virtual void AddScore()
        {
            roundsWon++;
        }//end AddScore
        public abstract void GestureChosen();
     
    }//end class
}//end namespace
