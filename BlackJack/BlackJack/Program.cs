using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
static string []card = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
static int []value = {11 , 2, 3, 4, 5, 6, 7, 8, 9, 10, 10 , 10, 10};
static  int player = 0;
static int dealer = 0;
static int i, j, sumP , sumD = 0;
static string choice ="";
static int q = 0;
static Random rnd=new Random();
static string []pHand =new string[20];
static int counter1 = 0;

static string []dHand = new string[20];
static int counter2 = 0;
      
        static void Main(string[] args)
        {
        
            string play = "";

            while (play != "q")
            {
                counter1 = 0;
                counter2 = 0;
                i = 0;
                j = 0;
                sumP = 0;
                sumD = 0;
                choice ="";

                playerPlay();

                if (sumP > 21)
                {
                    Console.WriteLine("Player Busts ! \n The dealer wins !");
                    dealer++;
                }
                else
                {
                    dealerPlay();

                    if (sumD > 21)
                    {
                        Console.Write("\n Dealer Busts !");
                    }
                    winCheck();
                }

                Console.WriteLine(" Enter q to quit, anything else to play another hand : ");
                play = Console.ReadLine();

            }

            points();
            Console.Write("\n\n Good Game , Come back next time");

        }
static void playerPlay()
{
    i = rnd.Next()%13;
    if(i==0&&q==0)
    {
        value[i]=11;
        q++;
    }
    else if (i == 0 && q == 1)
    {
        value[i] = 1;
        q = 0;
    }
    pHand[counter1] = card[i];
        counter1++;
    sumP = sumP + value[i];


    //i = rnd.Next()%13;
    //if(pHand[0] == card[0])
    //{
    //        value[0]=1;
    //}
    //else
    //{
    //        value[0]=11;
    //}
    //pHand[counter1] = card[i];
    //sumP = sumP + value[i];

    Console.Write("\n Player's Hand : ");
    playerHand();
        counter1++;

    Console.Write("\n Dealer's Hand : ");
    j = rnd.Next()%13;
        dHand[counter2] = card[j];
        dealerHand();
        counter2++;
    Console.Write(" X");
    sumD = sumD + value[j];

   Console.Write("\n Enter Command ('h' : TAKE ANOTHER HAND and 's' : DEALER'S PLAY) : ");
    choice=Console.ReadLine();

    while(choice != "s" && choice != "S" && sumP <= 21)
    {
        i = rnd.Next()%13;
    pHand[counter1] = card[i];
    Console.Write("\n Player's Hand : ");
    playerHand();
        counter1++;

        if(sumP > 10)
        {
             value[0] = 1;
        }
        else
            value[0]=11;
        sumP = sumP + value[i];

        if(sumP > 21)
        {
            break;
        }
        Console.Write("\n Enter Command ('h' = TAKE ANOTHER HAND and 's' = DEALER'S PLAY)  : ");
        choice=Console.ReadLine();

    }
    Console.Write("\n Your sum is {0} ", sumP);
}

static void dealerPlay()
{
    while(sumD <= 21)
       {
            Console.WriteLine("\n Dealer's Hand : ");
            j = rnd.Next()%13;
            dHand[counter2] = card[j];
        dealerHand();
        counter2++;
            if(sumD > 10)
            {
             value[0] = 1;
            }
            sumD = sumD + value[j];
       }
    Console.Write("\n The dealer's sum is {0} ", sumD);

}

static void winCheck()
{
    if(sumD > sumP && sumD <= 21)
    {
        dealer++;
        Console.WriteLine("\n The dealer wins !");
    }
    else if(sumD==sumP)
        Console.Write("\n Player and Dealer have same score, so it is a TIE!!");
    else
    {
        player++;
        Console.Write("\n Player wins !");
    }
}
static void playerHand()
{
    int k;
    for(k = 0; k <= counter1; k++)
    {
        if(pHand[k] == card[9])
        {
            Console.Write(" 10 ");
        }
        else
            Console.Write(pHand[k]+" ");
    }

}

static void dealerHand()
{
    int l;
    for(l = 0; l <= counter2; l++)
    {
        if(dHand[l] == card[9])
        {
            Console.Write(" 10 ");
        }
        else
            Console.Write(dHand[l]+" ");
    }

}
static void points()
{
    Console.Write("\n\n POINTS : PLAYER = {0} || DEALER =  {1} \n\n",player, dealer);
}
        }
      
    }
   

