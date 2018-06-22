using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        //member variables
        Player player1 = new Human();
        Player opponent = new Player();



        //constructor
        public Game()
        {
            








        }



        //methods


        public Player DetermineOpponent()
        {
            Console.WriteLine("Press 1 to play against another person or press 2 to play against the computer");
            string opponentChoice = Console.ReadLine();

            if(opponentChoice == "1")
            {
                opponent = new Human();
                return opponent;
            }
            else if(opponentChoice == "2")
            {
                opponent = new Computer();
                return opponent;
            }
            else
            {
                Console.WriteLine("Not a valid choice, try again");
                return DetermineOpponent();
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
                    Console.WriteLine("Scissors decapitate lizard, you wins this round");
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
        
       
        public bool CalculatesGameWinner(Player you, Player opponent)
        {
            if (you.numberOfMatchWins >= 2)
            {
                Console.WriteLine("You win the game!");
                return false;
            }
            if (opponent.numberOfMatchWins >= 2)
            {
                Console.WriteLine("Your opponent wins the game!");
                return false;
            }
            return true;
        }
    }   
}
