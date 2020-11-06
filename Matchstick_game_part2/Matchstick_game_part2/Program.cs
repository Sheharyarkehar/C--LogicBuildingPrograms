using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchstick_game_part2
{
    class Program
    {
        static void Main(string[] args)
        {
            int matchsticks = 21, userchange = 0, user1, user2;
            Console.WriteLine("Lets Play the Game of Matchsticks");
            while (matchsticks != 0)
            {
                if (userchange == 0)
                {
                    if (matchsticks == 1)
                    {
                        Console.WriteLine("User1 lose");
                        break;
                    }
                    else
                    {
                        Console.Write("User1's Turn:");
                        user1 = Convert.ToInt32(Console.ReadLine());
                        matchsticks -= user1;
                        while (matchsticks <=0)
                        {
                            matchsticks += user1;
                            Console.Write("User1's Turn:");
                            user1 = Convert.ToInt32(Console.ReadLine());
                            matchsticks -= user1;
                            //if (matchsticks == 2)
                            //{
                            //    Console.WriteLine("YoU Can't pick 3 or 4");
                            //}
                            //else if (matchsticks == 3)
                            //{
                            //    Console.WriteLine("YoU Can't pick 4 ");
                            //}
                            //if (matchsticks == 1)
                            //{
                            //    Console.WriteLine("Player1 lose");
                            //}
                        }
                        if (user1 < 5)
                        {
                          
                            Console.WriteLine("User1 picked {0} matchsticks", user1);
                            Console.WriteLine("Matchsticks left={0}", matchsticks);
                      
                        }
                        else
                        {
                            Console.WriteLine("invalid input");
                        }
                        userchange = 1;
                    }
                }


                      if (userchange == 1)
                    {
                        if (matchsticks ==1 )
                        {
                            Console.WriteLine("User2 lose");
                            break;
                        }
                        else
                        {
                            Console.Write("User2's Turn:");
                            user2 = Convert.ToInt32(Console.ReadLine());
                            matchsticks -= user2;
                            while (matchsticks<=0)
                            {
                                 matchsticks += user2;
                                Console.Write("User2's Turn:");
                                user2 = Convert.ToInt32(Console.ReadLine());
                                matchsticks -= user2;
                               
                              
                            }
                            if (user2 < 5)
                            {

                                Console.WriteLine("User2 picked {0} matchsticks", user2);
                               
                                Console.WriteLine("Matchsticks left={0}", matchsticks);
                             
                            }
                            else
                            {
                                Console.WriteLine("invalid input");
                            }
                            userchange = 0;
                        }
                    }
                }
            Console.ReadKey();
            }
        }
    }
