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
        public void DisplayRules()//display rules
        {
            Console.Clear();

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
        public void MainMenu()//allows user to decide to play which mode
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
                return;
            }//end IFSTATEMENT  
        }//end MainMenu
        public void RunGame()//runs game in order
        {
            DisplayRules();
            MainMenu();
            CompareGestures();
            PlayAgain();

        }//end RunGame

        public void CompareGestures()//see which gesture wins between each player
        {
            while (playerOne.roundsWon < roundsToWin & playerTwo.roundsWon < roundsToWin)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                if (playerOne.gesture == playerTwo.gesture)
                {
                    ShowGesturesThrownShowWinOrTied(playerOne, playerTwo);

                }// gesture TIE
                else if (playerOne.gesture == "ROCK")
                {
                    if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "LIZARD")
                    {
                        ShowGesturesThrownShowWinOrTied(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "PAPER" || playerTwo.gesture == "SPOCK")
                    {
                        ShowGesturesThrownShowWinOrTied(playerTwo, playerOne);
                    }
                }
                else if (playerOne.gesture == "LIZARD")
                {
                    if (playerTwo.gesture == "PAPER" || playerTwo.gesture == "SPOCK")
                    {
                        ShowGesturesThrownShowWinOrTied(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "ROCK")
                    {
                        ShowGesturesThrownShowWinOrTied(playerTwo, playerOne);
                    }

                }
                else if (playerOne.gesture == "SPOCK")
                {
                    if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "ROCK")
                    {
                        ShowGesturesThrownShowWinOrTied(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "LIZARD" || playerTwo.gesture == "PAPER")
                    {
                        ShowGesturesThrownShowWinOrTied(playerTwo, playerOne);
                    }

                }
                else if (playerOne.gesture == "SCISSORS")
                {
                    if (playerTwo.gesture == "PAPER" || playerTwo.gesture == "LIZARD")
                    {
                        ShowGesturesThrownShowWinOrTied(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "SPOCK" || playerTwo.gesture == "ROCK")
                    {
                        ShowGesturesThrownShowWinOrTied(playerTwo, playerOne);
                    }

                }
                else if (playerOne.gesture == "PAPER")
                {
                    if (playerTwo.gesture == "ROCK" || playerTwo.gesture == "SPOCK")
                    {
                        ShowGesturesThrownShowWinOrTied(playerOne, playerTwo);
                    }
                    else if (playerTwo.gesture == "SCISSORS" || playerTwo.gesture == "LIZARD")
                    {
                        ShowGesturesThrownShowWinOrTied(playerTwo, playerOne);
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
        public void PlayAgain()//ask user to play again or not
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
        public void ShowGesturesThrownShowWinOrTied(Player winner, Player loser)//Shows if win ,loss, or tie / display score / display gestures thrown
        {  
            Console.WriteLine("\n" + winner.name + " threw " + winner.gesture);
            Console.WriteLine("\n" + loser.name + " threw " + loser.gesture);
            if(winner.gesture == loser.gesture)
            {
                Console.WriteLine("\nLOOKS LIKE A TIE TO MEH, NO WINNERS! ");
            }
            else
            {
                winner.AddScore();
                Console.WriteLine("\n" + winner.name + " wins this round! ");
            }
            Console.WriteLine("\n\nScore   " + winner.name + " : " + winner.roundsWon + "\t\t" + loser.name + " : " + loser.roundsWon);//shows score
        }//end
    }//end class
}//end namespace
