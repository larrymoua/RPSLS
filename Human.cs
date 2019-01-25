using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        public Human()
        {
            roundsWon = 0;
               
        }//constructor
        public override void GestureChosen( )
        {
            int x = 6;
            int i;
            string[] gestureOptions = new string[5] { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };

            Console.WriteLine("\n\n" + name + " please select your Gesture.\n1.ROCK\n2.PAPER\n3.SCISSORS\n4.LIZARD\n5.SPOCK");
            i = Convert.ToInt16(Console.ReadLine());
            if ( i > x || i < 0)
            {
                Console.WriteLine("\n\nINVALID CHOICE, PLEASE TRY AGAIN!");
                GestureChosen();
            }
            gesture = gestureOptions[i-1];
          
        }//end GestureChosen
    }//end Class
}//end Namespace
