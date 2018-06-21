using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ComputerPlayer:Player
    {
        //member variables


        //constructor



        //methods
        public override void MakesChoice()
        {
            
            Random rnd = new Random();
            numberChoice = rnd.Next(1, 6).ToString();

            switch (numberChoice)
            {
                case "1":
                    playerChoice = "rock";
                    Console.WriteLine("The computer chose: " + playerChoice);
                    break;
                case "2":
                    playerChoice = "paper";
                    Console.WriteLine("The computer chose: " + playerChoice);
                    break;
                case "3":
                    playerChoice = "scissors";
                    Console.WriteLine("The computer chose: " + playerChoice);
                    break;
                case "4":
                    playerChoice = "lizard";
                    Console.WriteLine("The computer chose: " + playerChoice);
                    break;
                case "5":
                    playerChoice = "spock";
                    Console.WriteLine("The computer chose: " + playerChoice);
                    break;
                default:
                    Console.WriteLine("That is not a valid choice, try again");
                    break;

            }
        }
    }
}
