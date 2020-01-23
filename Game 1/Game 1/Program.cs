using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the game");
            Console.Write("You have entered the Game. would you like to conteniue Y/N");
            String inputOne = Console.ReadLine();
            String inputTwo = Console.ReadLine();

            if (inputOne == "Y")
            {
                Console.WriteLine("it is your Choise");
                Console.ReadLine();


            }
            else 
            {
                Console.WriteLine("");
 


            }

            Console.Write("Are you Ok? Y/N");
            String inputThree = Console.ReadLine();
            String inputFour = Console.ReadLine();

            if (inputThree == "Y")
            {
                Console.WriteLine("Nice");
                Console.ReadLine();


            }
            else 
            {
                Console.WriteLine("ooh, sorry. no i im not ");
                Console.ReadLine();


            }
        }
    }
}
