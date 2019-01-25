using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RockPaperScissorsLizardSpock
{
    class GamePlay
    {
        Player p1;
        Player p2;
   

        public GamePlay()
        {
        

        }//end constructor
        public void DisplayRules()
        {
            Console.WriteLine("\t\t\t\tRules");
            Console.WriteLine("\n\n\t\t\tROCK beats - LIZARD, SCISSORS");
            Console.WriteLine("\n\n\t\t\tLIZARD beats - PAPER, SPOCK");
            Console.WriteLine("\n\n\t\t\tSPOCK beats - ROCK, SCISSORS");
            Console.WriteLine("\n\n\t\t\tSCISSORS beats - LIZARD, PAPER");
            Console.WriteLine("\n\n\t\t\tPAPER beats - ROCK, SPOCK");

            Thread.Sleep(2000);

            Console.WriteLine("\n\nPress enter to continue....");
            Console.ReadLine();
        }//end display rules
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter (1) Human vs Computer or (2) Human vs Human");
            string whichMode = Console.ReadLine();
            if (whichMode == "1")
            {
                Console.Clear();
                Console.Write("Programming an opponent.");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                p1 = new Human();
                p2 = new Computer();
                Console.WriteLine("\nPlease enter name for first player");
                p1.name = Console.ReadLine();      
            }
            else if (whichMode == "2")
            {
                Console.Clear();
                p1 = new Human();
                p2 = new Human();
                Console.WriteLine("\nPlease enter name for first player");
                p1.name = Console.ReadLine();
                Console.WriteLine("\nPlease enter name for second player.");
                p2.name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("INVALID INPUT, PLEASE TRY AGAIN");
                MainMenu();
            }//end IFSTATEMENT  
        }//end MainMenu
        public void RunGame()
        {
            DisplayRules();
            MainMenu();
            CompareGestures();

        }//end RunGame
        public void CompareGestures()
        {
            while (p1.roundsWon < 2 & p2.roundsWon < 2)
            {
                p1.GestureChosen();
                p2.GestureChosen();

                if (p1.gesture == "ROCK")
                {
                    if (p2.gesture == "SCISSORS" || p2.gesture == "LIZARD")
                    {
                        CombatLog(p1, p2);
                    }
                    else if (p2.gesture == "PAPER" || p2.gesture == "SPOCK")
                    {
                        CombatLog(p2, p1);
                    }
                }
                else if (p1.gesture == "LIZARD")
                {
                    if (p2.gesture == "PAPER" || p2.gesture == "SPOCK")
                    {
                        CombatLog(p1, p2);
                    }
                    else if (p2.gesture == "SCISSORS" || p2.gesture == "ROCK")
                    {
                        CombatLog(p2, p1);
                    }

                }
                else if (p1.gesture == "SPOCK")
                {
                    if (p2.gesture == "SCISSORS" || p2.gesture == "ROCK")
                    {
                        CombatLog(p1, p2);
                    }
                    else if (p2.gesture == "LIZARD" || p2.gesture == "PAPER")
                    {
                        CombatLog(p2, p1);
                    }

                }
                else if (p1.gesture == "SCISSORS")
                {
                    if (p2.gesture == "PAPER" || p2.gesture == "LIZARD")
                    {
                        CombatLog(p1, p2);
                    }
                    else if (p2.gesture == "SPOCK" || p2.gesture == "ROCK")
                    {
                        CombatLog(p2, p1);
                    }

                }
                else if (p1.gesture == "PAPER")
                {
                    if (p2.gesture == "ROCK" || p2.gesture == "SPOCK")
                    {
                        CombatLog(p1, p2);
                    }
                    else if (p2.gesture == "SCISSORS" || p2.gesture == "LIZARD")
                    {
                        CombatLog(p2, p1);
                    }
                }
                if (p1.gesture == p2.gesture)
                {
                    CombatLogTie(p1, p2);

                }
            }//end Whileloop
            if (p1.roundsWon >= 2)
            {
                Console.WriteLine("\n\n" + p1.name + " won the game!");
               
            }
            else
            {
                
                Console.WriteLine("\n\n" + p2.name + " won the game!");
               
            }
            string yesNo;
            Console.WriteLine("\nDo you want to play again? y/n");
            yesNo = Console.ReadLine();
            if(yesNo == "y")
            {
                RunGame();
            }
            else
            {
                Environment.Exit(0);
            }
        }//end compareGestures
        public void CombatLog(Player winner, Player loser)
        {
            winner.AddScore();
            Console.WriteLine("\n" + winner.name + " threw " + winner.gesture);
            Console.WriteLine("\n" + loser.name + " threw " + loser.gesture);
            Console.WriteLine("\n" + winner.name + " wins this round! ");
            Console.WriteLine("\n\nScore   " + winner.name + " : " + winner.roundsWon + "\t\t" + loser.name + " : " + loser.roundsWon);
           

        }//end CombatLog
        public void CombatLogTie(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("\n" + playerOne.name + " threw " + playerOne.gesture);
            Console.WriteLine("\n" + playerTwo.name + " threw " + playerTwo.gesture);
            Console.WriteLine("\nLOOKS LIKE A TIE TO MEH, NO WINNERS! ");
            Console.WriteLine("\n\nScore   " + playerOne.name + " : " + playerOne.roundsWon + "\t\t" + playerTwo.name + " : " + playerTwo.roundsWon);
        }
    }//end class
}//end namespace
