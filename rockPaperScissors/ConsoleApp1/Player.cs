using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
      //member variables

        public int numberOfMatchWins;
        public string playerChoice;
        protected List<string> gestures = new List<string>() {"rock", "paper", "scissors", "lizard", "spock" };



        //constructor
        public Player()
        {
         
        }



        //methods

        public virtual string MakesChoice()
        {
            Console.WriteLine("Please choose a number 1 through 5 to make your move");
            

            switch(Console.ReadLine())
            {
                case "1":
                    playerChoice = gestures[0];
                    Console.WriteLine("You chose " + playerChoice);
                    return playerChoice;
                case "2":
                    playerChoice = gestures[1];
                    Console.WriteLine("You chose " + playerChoice);
                    return playerChoice;
                case "3":
                    playerChoice = gestures[2];
                    Console.WriteLine("You chose " + playerChoice);
                    return playerChoice;
                case "4":
                    playerChoice = gestures[3];
                    Console.WriteLine("You chose " + playerChoice);
                    return playerChoice;
                case "5":
                    playerChoice = gestures[4];
                    Console.WriteLine("You chose " + playerChoice);
                    return playerChoice;
                default:
                    Console.WriteLine("That is not a valid choice, try again");
                    return MakesChoice();
                    
                   

            }

        }

        

    }
}
