using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata6
{
   
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Alphabet");
                String input = Console.ReadLine();

                String[] a = new String[input.Length];
                int j = 0;
                int J = 0;
                int flag = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    string concat = "";
                    if (input[i] == ',' || input[i] == '}')
                    {
                        for (; J <= i; J++)
                        {
                            if (input[J] != ',' || input[i] != '}')
                            {
                                if (input[J] == '{' || input[J] == '}' || input[J] == ',')
                                {
                                    continue;
                                }
                                else
                                {
                                    concat += input[J];

                                    flag = 1;
                                }
                            }
                            else
                            {
                                break;
                            }

                        }
                    }


                    if (flag == 1)
                    {

                        a[j] = concat;
                        flag = 0;
                        j++;
                        //J++;
                        concat = "";

                    }


                }
                int count = 0;
                int flag1 = 0;
                for (int i = 0; i < j; i++)
                {
                    for (int k = i + 1; k < j; k++)
                    {

                        if (a[i].Length > a[k].Length)
                        {
                            char[] x = a[k].ToCharArray();
                            char[] y = a[i].ToCharArray();
                            for (int d = 0; d < a[k].Length; d++)
                            {
                                if (x[d] == y[d])
                                {

                                    count++;
                                }
                            }
                            if (count == x.Length)
                            {
                                Console.WriteLine("invalid");
                                flag1 = 1;
                                break;
                            }
                        }
                        else
                        {
                            char[] x = a[k].ToCharArray();
                            char[] y = a[i].ToCharArray();
                            for (int d = 0; d < a[i].Length; d++)
                            {
                                if (x[d] == y[d])
                                {

                                    count++;
                                }
                            }
                            if (count == y.Length)
                            {
                                Console.WriteLine("invalid");
                                flag1 = 1;
                                break;
                            }

                        }
                        count = 0;

                    }


                    if (flag1 == 1)
                    {
                        break;
                    }

                }
                if (flag1 == 0)
                {

                    Console.WriteLine("valid");
                }

                Console.WriteLine("give number of states");
                int states = Convert.ToInt32(Console.ReadLine());
                char[,] createStates = new char[states,3];

                for (int i = 0; i < createStates.GetLength(0); i++)
                {
                    for (int mn = 0; mn < createStates.GetLength(1); mn++)
                    {
                        createStates[i, mn] = Convert.ToChar(Console.ReadLine());
                    }
                }

                char[] checking = new char[states];
                char f = '0';
                Console.WriteLine("\ttransition\ta\tb\tstates");
                for (int i = 0; i < createStates.GetLength(0); i++)
                {
                    for (int q = 0; q < createStates.GetLength(1); q++)
                    {
                        Console.Write("\t" + createStates[i, q]);
                    }
                    if (i < states)
                    {
                        checking[i] = f;
                        f++;
                    }
                    Console.WriteLine();
                }



                Console.WriteLine("Enter String ");
                String input1 = Console.ReadLine();
                char[] st = new char[2];
                char[] t = input1.ToCharArray();
                //Console.WriteLine(t[0]);
                //Console.WriteLine(t[1]);
                //Console.WriteLine(t[2]);
                //Console.WriteLine(t[3]);
                st[0] = Convert.ToChar(a[0]);
                st[1] = Convert.ToChar(a[1]);
                int ch = 2;

                int index = 0;
                String co = "";
                int chf = 2;
                int ff = 0;
                for (ff = 0; ff < t.Length; ff++)
                {

                    for (int mn = 0; mn < st.Length; mn++)
                    {


                        if (t[ff] == st[mn])
                        {

                            ch = ff;
                            if (createStates[index, mn] != 'n')
                            {
                                co = createStates[index, mn].ToString();
                                index = Convert.ToInt32(co);
                            }
                            else
                            {
                                Console.WriteLine("invalid transition");
                                break;
                            }
                        



                    }
                    if (ff == t.Length - 1 && createStates[index, st.Length] != 'f')
                    {

                        Console.WriteLine("invalid transition");
                        break;
                    }


                }

                    



            }
                if (ff == t.Length && createStates[index, st.Length] == 'f')
                {
                    Console.WriteLine("valid");
                }
        }
    }
}
