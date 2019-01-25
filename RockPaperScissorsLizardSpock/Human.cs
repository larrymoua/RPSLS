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
        public override void GestureChosen()
        {
            int i;
            string[] gestureOptions = new string[5] { "ROCK", "PAPER", "SCISSORS", "LIZARD", "SPOCK" };

            Console.WriteLine("\n\n" + name + " please select your Gesture.\n1.ROCK\n2.PAPER\n3.SCISSORS\n4.LIZARD\n5.SPOCK");

            try
            {
                i = Convert.ToInt16(Console.ReadLine());
                gesture = gestureOptions[i-1];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\n\nINVALID CHOICE, INDEX SHOULD BE FROM 1-5!");
                GestureChosen();
            }
            catch(FormatException)
            {
                Console.WriteLine("\n\nINVALID CHOICE, MUST BE AN INTEGER!");
                GestureChosen();
            } //end tryCatch             
            
           
          
        }//end GestureChosen
    }//end Class
}//end Namespace
