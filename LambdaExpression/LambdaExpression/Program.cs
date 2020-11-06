using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace LambdaExpressions
    {
        class Program
        {
            //delegate int Square(int num);
            static void Main(string[] args)
            {
                //Square GetSquare = x => x * x;
                //int j = GetSquare(5);
                //Console.WriteLine("Square: " + j);
                Func<int,double> f = x => (double)(x + 1);
                int[] a = { 1, 2, 3 };
                //for (int i = 0; i <a.Length; i++)
                //{
                //    Console.WriteLine(a[i]);
                //}
                Array.ForEach(a,x => Console.WriteLine(x));
                Console.WriteLine(f.Invoke(2));
                //Func<int, int> func3 = (int x) => x + 1;
                //Console.WriteLine(f.Invoke(2));
                Cat cat = new Cat();
                cat.Feed();
                cat.MyDel = Print;
                cat.Feed();
                cat.Feed();
                cat.Feed();
                cat.Feed();
            }

            static int Print()
            {
                Console.WriteLine("Hello ");
                return 2 + 3;
            }
        }

        class Cat
        {
            public Func<int> MyDel;
            int feed = 0;

            public void Feed()
            {
                feed++;
                if (feed == 5)
                    MyDel();
            }
        }
    }
