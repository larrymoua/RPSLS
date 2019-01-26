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
        Player playerOne;
        Player playerTwo;
        int roundsToWin;
   

        public GamePlay()
        {
            roundsToWin = 2;

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
                playerOne = new Human();
                playerTwo = new Computer();
                Console.WriteLine("\nPlease enter name for first player");
                playerOne.name = Console.ReadLine();      
            }
            else if (whichMode == "2")
            {
                Console.Clear();
                playerOne = new Human();
                playerTwo = new Human();
                Console.WriteLine("\nPlease enter name for first player");
                playerOne.name = Console.ReadLine();
                Console.WriteLine("\nPlease enter name for second player.");
                playerTwo.name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("INVALID INPUT, PLEASE TRY AGAIN");
                Thread.Sleep(2000);
                MainMenu();
            }//end IFSTATEMENT  
        }//end MainMenu
        public void RunGame()
        {
            DisplayRules();
            MainMenu();
            CompareGestures();
            PlayAgain();

        }//end RunGame
        public void CompareGestures()
        {
            while (playerOne.roundsWon < roundsToWin & playerTwo.roundsWon < roundsToWin)
            {
                playerOne.GestureChosen();
                playerTwo.GestureChosen();

                if (playerOne.gesture == playerTwo.gesture)
                {
                    CombatLogTie(playerOne, playerTwo);

                }// gesture TIE
                else if (playerOne.gesture == "ROCK")
                {
                    if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "LIZARD")
                    {
                        CombatLog(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "PAPER" || playerTwo.gesture == "SPOCK")
                    {
                        CombatLog(playerTwo, playerOne);
                    }
                }
                else if (playerOne.gesture == "LIZARD")
                {
                    if (playerTwo.gesture == "PAPER" || playerTwo.gesture == "SPOCK")
                    {
                        CombatLog(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "ROCK")
                    {
                        CombatLog(playerTwo, playerOne);
                    }

                }
                else if (playerOne.gesture == "SPOCK")
                {
                    if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "ROCK")
                    {
                        CombatLog(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "LIZARD" || playerTwo.gesture == "PAPER")
                    {
                        CombatLog(playerTwo, playerOne);
                    }

                }
                else if (playerOne.gesture == "SCISSORS")
                {
                    if (playerTwo.gesture == "PAPER" || playerTwo.gesture == "LIZARD")
                    {
                        CombatLog(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "SPOCK" || playerTwo.gesture == "ROCK")
                    {
                        CombatLog(playerTwo, playerOne);
                    }

                }
                else if (playerOne.gesture == "PAPER")
                {
                    if (playerTwo.gesture == "ROCK" || playerTwo.gesture == "SPOCK")
                    {
                        CombatLog(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "LIZARD")
                    {
                        CombatLog(playerTwo, playerOne);
                    }
                }
            }//end Whileloop
            if (playerOne.roundsWon >= roundsToWin)
            {
                Console.WriteLine("\n\n" + playerOne.name + " won the game!");
               
            }
            else
            {
                
                Console.WriteLine("\n\n" + playerTwo.name + " won the game!");
               
            }   
        }//end compareGestures
        public void PlayAgain()
        {
            string yesNo;
            Console.WriteLine("\n\nDo you want to play again? y/n");
            yesNo = Console.ReadLine().ToLower();
            
            if(yesNo == "y")
            {
                RunGame();
            }
            else if(yesNo == "n")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\nINVALID INPUT");
                PlayAgain();
            }
        }//end PlayAgain
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
