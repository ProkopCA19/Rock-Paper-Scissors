using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock, paper, scissors, lizard, spock! The rules are as follows: rock crushes scissors, scissors cuts paper, paper covers rock, rock crushes lizard, lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper, paper disproves Spock, Spock vaporizes rock");
            Console.WriteLine("1 = rock");
            Console.WriteLine("2 = paper");
            Console.WriteLine("3 = scissors");
            Console.WriteLine("4 = lizard");
            Console.WriteLine("5 = spock");


            Game game1 = new Game();
        }
    }
}
