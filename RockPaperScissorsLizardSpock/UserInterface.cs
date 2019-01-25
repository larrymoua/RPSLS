using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace RockPaperScissorsLizardSpock
{
    class UserInterface
    {
        public UserInterface()
        {
        
        }//end constructor
        public void Background()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

        }//end background
        public void IntroPage()
        {
            Console.WriteLine("\t\t\t\t __ _     ____");
            Console.WriteLine("\t\t\t\t|-|-|    /-/-/");
            Console.WriteLine("\t\t\t\t| | |   / / / ");
            Console.WriteLine("\t\t\t\t| | |__/ / / __");
            Console.WriteLine("\t\t\t\t|          |/-/");
            Console.WriteLine("\t\t\t\t| LarGaming  /");
            Console.WriteLine("\t\t\t\tL___________/ ");

            Console.WriteLine("\n\n\t\t\tRock, Paper, Scissors, Lizard, SPOCK");
            Console.WriteLine("\n\t\t\tThanks BigBangTheory");

            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);

            Thread.Sleep(1000);

            Console.Clear();
        }//end intropage
    }//end class
}//end namespace
