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
               
        }//constructor
        public override void GestureChosen()
        {
            int index;

            for(int i = 0; i < gestureOptions.Count ; i++)
            {
                Console.WriteLine($"\n{i+1}" + " ." + gestureOptions[i]);
            }
            try
            {
                index = Convert.ToInt16(Console.ReadLine());
                gesture = gestureOptions[index-1];
            }
            catch (Exception)
            {
                Console.WriteLine("\n\nINVALID CHOICE, PLEASE TRY AGAIN!");
                return;
            }//end tryCatch                    
        }//end GestureChosen
    }//end Class
}//end Namespace
