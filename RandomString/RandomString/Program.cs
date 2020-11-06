using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomString
{
    class Program
    {
        static void Main(string[] args)
        {    
                    string []cards={"A","2","3","4","5","6","7","8","9","K","Q","J"};
            int[] Values = { 11,2, 3, 4, 5, 6, 7, 8, 9,10, 10, 10 };
            string[] OP = new string[12];
            int Index = 0;
            //int[] I = new int[14];
            int i = 0;
            //string choices;
            Random ran=new Random();
            //string PlayersHand, DealersHand;
            for (i = 0; i <2; i++)
            {
                Console.WriteLine("Players Hand"+PlayersTurn(cards[ran.Next(0, 11)]));
            }
            for (i = 0; i <2; i++)
            {
                Console.WriteLine("Dealers Hand"+DealersTurn(cards[ran.Next(0, 11)]));
            }


        }
        static string PlayersTurn(string op)
        {
            string c = "";
            for (int i = 0; i < 1; i++)
            {
                c = op;
            }
            return c;

        }
        static string DealersTurn(string op)
        {
            string c = "";
            for (int i = 0; i < 1; i++)
            {
                c = op;
            }
            return c;
        }
        
    

    }
}

