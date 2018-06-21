using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer:Player
    {
        //member variables


        //constructor
        public Computer()
        {

        }


        //methods
        public override string MakesChoice()
        {
            
            Random rnd = new Random();
            int random = rnd.Next(0, gestures.Count);

            playerChoice = gestures[random];
            return playerChoice;

        }
    }
}
