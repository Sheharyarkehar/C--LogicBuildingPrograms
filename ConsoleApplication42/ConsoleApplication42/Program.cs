﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                Console.Write(i);
                if (i % 2 == 0)
                    continue;
                Console.WriteLine();
            }
        }
    }
}
