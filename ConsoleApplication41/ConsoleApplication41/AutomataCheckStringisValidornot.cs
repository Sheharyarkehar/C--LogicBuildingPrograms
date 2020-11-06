using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabet");
            String input = Console.ReadLine();
        
            String [] a = new String[input.Length];
            int j=0;
            int J = 0;
            int flag = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string concat = "";
                if (input[i] == ',' || input[i] == '}')
                {
                    for (; J <=i; J++)
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
               
                
                if (flag == 1) {
                   
                    a[j] = concat;
                    flag = 0;
                    j++;
                    //J++;
                    concat = "";
                    
                }
                    
               
            }
            int count = 0;
            int flag1 = 0;
            for (int i = 0; i <j ; i++)
            {
                for (int k = i+1; k <j; k++)
                {
                   
                    if (a[i].Length > a[k].Length)
                    {
                        char[] x =a[k].ToCharArray();
                        char[] y = a[i].ToCharArray();
                        for (int d = 0; d < a[k].Length; d++)
                        {
                            if (x[d] == y[d]) {

                                count++;
                            }
                        }
                        if (count == x.Length) {
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
            
                
                if (flag1 == 1) {
                    break;
                }
               
            }
            if (flag1 == 0) {

                Console.WriteLine("valid");
            }
        }
    }
}
        
