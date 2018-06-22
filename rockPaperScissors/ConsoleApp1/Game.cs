using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
      
        Player you = new Human();
        Player opponent;


 
        public void RunGame()
        {
            DisplayRules();
            DetermineOpponent();
            
            while (DetermineIfPlayAgain())
            {
                Console.WriteLine("You chose:  " + you.MakesChoice());
                Console.WriteLine("Your opponent chose:  " + opponent.MakesChoice());
                CompareGestures(you, opponent);
            }
            PlayAgain();
        }


        public void PlayAgain()
        {
            Console.WriteLine("Press 1 to play again or press 2 to quit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    RunGame();
                    break;
                case "2":
                    Console.WriteLine("Goodbye :(");
                    break;
                default:
                    Console.WriteLine("Not a valid option, try again");
                    PlayAgain();
                    break;
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to rock, paper, scissors, lizard, spock! The rules are as follows:");
            Console.WriteLine("rock crushes scissors");
            Console.WriteLine("scissors cuts paper");
            Console.WriteLine("paper covers rock");
            Console.WriteLine("rock crushes lizard");
            Console.WriteLine("lizard poisons Spock");
            Console.WriteLine("Spock smashes scissors");
            Console.WriteLine("scissors decapitates lizard");
            Console.WriteLine("lizard eats paper");
            Console.WriteLine("paper disproves Spock");
            Console.WriteLine("Spock vaporizes rock");
            Console.WriteLine("1 = rock");
            Console.WriteLine("2 = paper");
            Console.WriteLine("3 = scissors");
            Console.WriteLine("4 = lizard");
            Console.WriteLine("5 = spock");
        }

        public void DetermineOpponent()
        {
            Console.WriteLine("Press 1 to play against another person or press 2 to play against the computer");
            string opponentChoice = Console.ReadLine();

            if(opponentChoice == "1")
            {
                opponent = new Human();
               
            }
            else if(opponentChoice == "2")
            {
                opponent = new Computer();
                
            }
            else
            {
                Console.WriteLine("Not a valid choice, try again");
                DetermineOpponent();
            }
        }

        public void CompareGestures(Player you, Player opponent)
        {           
                if (you.playerChoice == opponent.playerChoice)
                {
                    Console.WriteLine("Tie");
                }
                else if (you.playerChoice == "rock" && opponent.playerChoice == "scissors")
                {
                    Console.WriteLine("rock crushes scissors, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "rock" && opponent.playerChoice == "paper")
                {
                    Console.WriteLine("Paper covers rock, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "rock" && opponent.playerChoice == "lizard")
                {
                    Console.WriteLine("rock crushes lizard, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "rock" && opponent.playerChoice == "spock")
                {
                    Console.WriteLine("Spock vaporizes rock, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "paper" && opponent.playerChoice == "scissors")
                {
                    Console.WriteLine("Scissors cuts paper, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "paper" && opponent.playerChoice == "rock")
                {
                    Console.WriteLine("Paper covers rock, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "paper" && opponent.playerChoice == "lizard")
                {
                    Console.WriteLine("Lizard eats paper, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "paper" && opponent.playerChoice == "spock")
                {
                    Console.WriteLine("Paper disproves spockd, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "scissors" && opponent.playerChoice == "rock")
                {
                    Console.WriteLine("Rock crushes scissors, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "scissors" && opponent.playerChoice == "paper")
                {
                    Console.WriteLine("Scissors cuts paper, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "scissors" && opponent.playerChoice == "lizard")
                {
                    Console.WriteLine("Scissors decapitate lizard, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "scissors" && opponent.playerChoice == "spock")
                {
                    Console.WriteLine("Spock smashes scissors, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "lizard" && opponent.playerChoice == "rock")
                {
                    Console.WriteLine("Rock crushes lizard, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "lizard" && opponent.playerChoice == "paper")
                {
                    Console.WriteLine("Lizard eats paper, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "lizard" && opponent.playerChoice == "scissors")
                {
                    Console.WriteLine("Scissors decapitates lizard, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "lizard" && opponent.playerChoice == "spock")
                {
                    Console.WriteLine("Lizard poisons spock, you win this round");
                    you.numberOfMatchWins++;
                }

                else if (you.playerChoice == "spock" && opponent.playerChoice == "rock")
                {
                    Console.WriteLine("Spock vaporizes rock, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "spock" && opponent.playerChoice == "paper")
                {
                    Console.WriteLine("Paper disproves spock, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
                else if (you.playerChoice == "spock" && opponent.playerChoice == "scissors")
                {
                    Console.WriteLine("Spock smashes scissors, you win this round");
                    you.numberOfMatchWins++;
                }
                else if (you.playerChoice == "spock" && opponent.playerChoice == "lizard")
                {
                    Console.WriteLine("Lizard poisons spock, your opponent wins this round");
                    opponent.numberOfMatchWins++;
                }
            
        }
        
       
        public bool DetermineIfPlayAgain(/*Player you, Player opponent*/)
        {
            if (you.numberOfMatchWins >= 2)
            {
                Console.WriteLine("");
                Console.WriteLine("You win the game!");
                return false;
            }
            if (opponent.numberOfMatchWins >= 2)
            {
                Console.WriteLine("");
                Console.WriteLine("Your opponent wins the game!");
                return false;
            }
            return true;
        }
    }   
}
