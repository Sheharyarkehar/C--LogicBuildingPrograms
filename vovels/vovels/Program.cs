using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vovels
{
    class Program
    {
        static void Main(string[] args)
        {
            char inp = Convert.ToChar(Console.ReadLine());
            if ((inp == 'a' || inp == 'e' || inp == 'i' || inp == 'o' || inp == 'u') || (inp == 'A' || inp == 'E' || inp == 'I' || inp == 'O' || inp == 'U'))
            {
                if (inp >= 'a' && inp <= 'z')
                {
                    Console.WriteLine("vowels");
                }
                else if (((inp != 'a' || inp != 'e' || inp != 'i' || inp != 'o' || inp != 'u') || (inp != 'A' || inp != 'E' || inp != 'I' || inp != 'O' || inp != 'U')) && ((inp == 'b' || inp == 'c' || inp == 'd' || inp == 'f' || inp == 'g' || inp == 'h' || inp == 'j' || inp == 'k' || inp == 'l' || inp == 'm' || inp == 'n' || inp == 'p' || inp == 'q' || inp == 'r' || inp == 's' || inp == 't' || inp == 'u' || inp == 'v' || inp == 'w' || inp == 'x' || inp == 'y' || inp == 'z') || (inp == 'B' || inp == 'C' || inp == 'D' || inp == 'F' || inp == 'G' || inp == 'H' || inp == 'J' || inp == 'K' || inp == 'L' || inp == 'M' || inp == 'N' || inp == 'P' || inp == 'Q' || inp == 'R' || inp == 'S' || inp == 'T' || inp == 'U' || inp == 'V' || inp == 'W' || inp == 'X' || inp == 'Y' || inp == 'Z')))
                {
                    Console.WriteLine("Consonent");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }


            }
        }
    }
}

