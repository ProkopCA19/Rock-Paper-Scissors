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
        Player player2;



        //constructor
        public Game()
        {
            
        }



        //methods


        public Player DecidesHumanOrComputer()
        {
            Console.WriteLine("Press 1 to play against another person or press 2 to play against the computer");
            string opponent = Console.ReadLine();

            if(opponent == "1")
            {
                player2 = new Human();
                return player2;
            }
            else if(opponent == "2")
            {
                player2 = new Computer();
                return player2;
            }
            else
            {
                Console.WriteLine("Not a valid choice, try again");
                return DecidesHumanOrComputer();
            }
        }

        public void CompareGestures()
        {
            while (player1.numberOfMatchWins < 2 || player2.numberOfMatchWins < 2)
            {

                if (player1.playerChoice == player2.playerChoice)
                {
                    Console.WriteLine("Tie");
                }
                else if (player1.playerChoice == "rock" && player2.playerChoice == "scissors")
                {
                    Console.WriteLine("rock crushes scissors, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "rock" && player2.playerChoice == "paper")
                {
                    Console.WriteLine("Paper covers rock, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "rock" && player2.playerChoice == "lizard")
                {
                    Console.WriteLine("rock crushes lizard, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "rock" && player2.playerChoice == "spock")
                {
                    Console.WriteLine("Spock vaporizes rock, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "paper" && player2.playerChoice == "scissors")
                {
                    Console.WriteLine("Scissors cuts paper, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "paper" && player2.playerChoice == "rock")
                {
                    Console.WriteLine("Paper covers rock, player player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "paper" && player2.playerChoice == "lizard")
                {
                    Console.WriteLine("Lizard eats paper, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "paper" && player2.playerChoice == "spock")
                {
                    Console.WriteLine("Paper disproves spockd, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "scissors" && player2.playerChoice == "rock")
                {
                    Console.WriteLine("Rock crushes scissors, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "scissors" && player2.playerChoice == "paper")
                {
                    Console.WriteLine("Scissors cuts paper, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "scissors" && player2.playerChoice == "lizard")
                {
                    Console.WriteLine("Scissors decapitate lizard, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "scissors" && player2.playerChoice == "spock")
                {
                    Console.WriteLine("Spock smashes scissors, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "lizard" && player2.playerChoice == "rock")
                {
                    Console.WriteLine("Rock crushes lizard, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "lizard" && player2.playerChoice == "paper")
                {
                    Console.WriteLine("Lizard eats paper, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "lizard" && player2.playerChoice == "scissors")
                {
                    Console.WriteLine("Scissors decapitates lizard, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "lizard" && player2.playerChoice == "spock")
                {
                    Console.WriteLine("Lizard poisons spock, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "spock" && player2.playerChoice == "rock")
                {
                    Console.WriteLine("Spock vaporizes rock, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "spock" && player2.playerChoice == "paper")
                {
                    Console.WriteLine("Paper disproves spock, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "spock" && player2.playerChoice == "scissors")
                {
                    Console.WriteLine("Spock smashes scissors, player 1 wins this round");
                    player1.numberOfMatchWins++;
                }
                else if (player1.playerChoice == "spock" && player2.playerChoice == "lizard")
                {
                    Console.WriteLine("Lizard poisons spock, player 2 wins this round");
                    player2.numberOfMatchWins++;
                }
            }
        }
        
       
        public void CalculatesGameWinner()
        {
            if (player1.numberOfMatchWins > player2.numberOfMatchWins)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }
        }
    }
}
