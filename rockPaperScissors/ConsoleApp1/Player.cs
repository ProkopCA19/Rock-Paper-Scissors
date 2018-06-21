using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        string numberChoice;
        string numberOfMatchWins;
        string playerChoice;

        //constructor
        public Player()
        {

        }

        //methods

        public virtual void MakesChoice()
        {
            Console.WriteLine("Please choose a number 1 through 5 to make your move");
            numberChoice = Console.ReadLine();
            

            switch(numberChoice)
            {
                case "1":
                    playerChoice = "rock"; 
                    Console.WriteLine("You chose " + playerChoice);
                        break;
                case "2":
                    playerChoice = "paper";
                    Console.WriteLine("You chose " + playerChoice);
                    break;
                case "3":
                    playerChoice = "scissors";
                    Console.WriteLine("You chose " + playerChoice);
                    break;
                case "4":
                    playerChoice = "lizard";
                    Console.WriteLine("You chose " + playerChoice);
                    break;
                case "5":
                    playerChoice = "spock";
                    Console.WriteLine("You chose " + playerChoice);
                    break;
                default:
                    Console.WriteLine("That is not a valid choice, try again");
                    break;

            }

        }

        

    }
}
