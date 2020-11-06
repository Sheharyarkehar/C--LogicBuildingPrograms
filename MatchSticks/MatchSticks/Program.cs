using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            //int matchsticks = 21;
            //int n;
            //while (matchsticks != 0) {
            //    Console.WriteLine("Pick matchsticks 1 2 3 4");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    while (n > 4) {

            //        Console.WriteLine("Pick matchsticks 1 2 3 4");
            //         n = Convert.ToInt32(Console.ReadLine());
                
            //    }
            //    matchsticks -= n;
            //    Console.WriteLine("you picked {0} matchsticks",n);
            //    Console.WriteLine("{0} matchstiks left",matchsticks);
            
            
            //}
            int matchstick = 21;
            int user, computer;

            while (matchstick >= 1)
            {

                if (matchstick == 1)
                {
                    Console.WriteLine("\nMatch stick status:{0}", matchstick);
                    Console.WriteLine("\nYou loose!!!!!!:(:(");
                    break;
                }

                Console.WriteLine("\nMatch stick status:{0}", matchstick);
                Console.WriteLine("\nEnter the choice (1,2,3,4)):");
                user = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nYou picked {0}", user);
                if (user >= 5 || user <= 0)
                {
                    Console.WriteLine("\nInvalid value");
                    continue;
                }

                computer = 5 - user;

                Console.WriteLine("\nComputer picked{0}", computer);
                matchstick = matchstick - computer - user;

            }
            Console.ReadKey();
            //int i, count = 0;
            //for ( i = 0; i <=24; i++)
            //{
            //    if (count == 5)
            //    {
            //        Console.WriteLine("");
            //        count = 0;
            //    }
            //    Console.Write("{0}\t",i);
            //    count++;
            //}


        }
    }
}
