using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace automata2
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Enter Alphabet");
            String input = Console.ReadLine();
            int ww = 0;
            
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
            //for (int i = 0; i < j; i++)
            //{
            //    Console.WriteLine(a[i]);     
            //}

            if (flag1 == 0)
            {

                Console.WriteLine("valid");
                for (int i = 0; i <j-1; i++)
                {
                    for (int o = i+1; o <j; o++)
                    {
                        if (a[o].Length > a[i].Length) {

                            string temp = a[i];
                            a[i] = a[o];
                            a[o] = temp;
                        }
                    }
                }



                Console.WriteLine("Enter String");
                string str = Console.ReadLine();
                int[] indexSav = new int[100];
                int coutin=0;
                char[] nstr = str.ToCharArray();

                for (int i = 0; i < j; i++)
                {
                    char[] x = a[i].ToCharArray();
                    int xi = 0;
                    for (int p = 0; p < nstr.Length; p++)
                    {
                        if (x[xi] == nstr[p])
                        {
                            int w = p;
                            int count2 = 0;
                            for (
                                int l = 0; l < a[i].Length; l++)
                            {

                                if (x[l] == nstr[w])
                                {

                                    count2++;
                                    
                                }
                                w++;


                            }
                            if (count2 == a[i].Length  )
                            {

                                for (int ind = p; ind < w; ind++)
                                {

                                       indexSav[coutin] = ind;
                                    coutin++;
                                }
                                p = (p + count2) - 1;
                                int dd = 0;
                                for (int ind = p; ind <w ; ind++)
                                {
                                    for (int ch = 0; ch < coutin; ch++)
			{
                if (nstr[ind] == indexSav[ch]) {
                    dd = 1;
                    break;
                }
			}
                                    if (dd == 1) {
                                        break;
                                    }
                                }
                                if (dd == 0)
                                {
                                    count = count + count2;
                                }
                            }

                        }
                        if (count == nstr.Length)
                        {
                            // Console.WriteLine("Valid he string");
                            break;
                        }
                    }
                    if (count == nstr.Length)
                    {
                        Console.WriteLine("Valid he string");
                        break;
                    }

                }

                if (count != nstr.Length)
                {
                    Console.WriteLine("Nh he valid");
                }
                //Console.WriteLine(count);

                //for (int i = 0; i <coutin ; i++)
                //{
                //    Console.WriteLine(indexSav[i]);
                //}
            }
        }
    }
}
