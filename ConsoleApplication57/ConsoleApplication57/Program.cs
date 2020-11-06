using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication57
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(HexToDec("A"));

           
            
        }
        public int BinToHex(int bin)
        {

            int x = BinToDec(bin);
            string l = DecToHex(x);
            return l;
        }
        public int OctToHex(int oct)
        {

            int x = OctToDec(oct);
            string l = DecToHex(x);
            return l;
        }
        public int HexToBin(string hex)
        {

            int x = HexToDec(hex);
            return DecToBin(x);
        }
        public int HexToOct(string hex)
        {

           int x= HexToDec(hex);
           return DecToOct(x);
        }
        public int HexToDec(string HexNumber)
        {
          
            int x = Convert.ToInt32(HexNumber, 16);
            return x;
           

        }
        public string DecToHex(int decimalNumber)
        {
            int quotient;
            string x = "";
            int i = 1, j, temp = 0;
            char[] hexadecimalNumber = new char[100];
            char temp1;
            quotient = decimalNumber;
            while (quotient != 0)
            {
                temp = quotient % 16;
                if (temp < 10)
                    temp = temp + 48;
                else
                    temp = temp + 55;
                temp1 = Convert.ToChar(temp);
                hexadecimalNumber[i++] = temp1;
                quotient = quotient / 16;
            }
            for (j = i - 1; j > 0; j--)
                x += hexadecimalNumber[j];

            return x;
        }

    }
}
