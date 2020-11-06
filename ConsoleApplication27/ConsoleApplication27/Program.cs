using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput1;
            Console.WriteLine(" there are 21 matchsticks the one who chooses last will loss");
            Console.WriteLine(" Lets Play ");
            int matchstick = 21;
            Console.WriteLine(" user and computer input can not greater than 4 ");
            if (matchstick >= 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(" \n User Choice ");
                    userinput1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("User choose {0} matchsticks",userinput1);
                    if (userinput1 > 4)
                    {
                        Console.WriteLine(" enter input less than 5  ");
                        userinput1 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("\n Computer Choice ");
                    int compinput1 = 5 - userinput1;
                    Console.WriteLine("Computer choose {0} matchsticks",compinput1);
                     matchstick=matchstick-compinput1-userinput1;
                    Console.WriteLine(" " + compinput1);
                    Console.WriteLine("  ");
                    Console.WriteLine("Matchsticks left {0}",matchstick);
                }
                Console.WriteLine("Only One Matchstick is remaining... ");
                Console.WriteLine(" Choose Match stick  ");
                userinput1 = Convert.ToInt32(Console.ReadLine());
                if (userinput1 > 1)
                {
                    Console.WriteLine(" enter input less than 1 bcz only one is remaining  ");
                    userinput1 = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("  SOrry You Loss CPU win :)");

            }
        }
    }
}
