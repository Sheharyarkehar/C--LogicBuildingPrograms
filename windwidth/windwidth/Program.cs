﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windwidth
{
    class Program
    {
        static void Main(string[] args)
        {
            int origWidth, width;
            int origHeight, height;
            string m1 = "The current window width is {0}, and the " +
                        "current window height is {1}.";
            string m2 = "The new window width is {0}, and the new " +
                        "window height is {1}.";
            string m4 = "  (Press any key to continue...)";
            //
            // Step 1: Get the current window dimensions.
            //
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            Console.WriteLine(m1, Console.WindowWidth,
                                  Console.WindowHeight);
            Console.WriteLine(m4);
            Console.ReadKey(true);
            //
            // Step 2: Cut the window to 1/4 its original size.
            //
            width = origWidth / 2;
            height = origHeight / 2;
            Console.SetWindowSize(width, height);
            Console.WriteLine(m2, Console.WindowWidth,
                                  Console.WindowHeight);
            Console.WriteLine(m4);
            Console.ReadKey(true);
            //
            // Step 3: Restore the window to its original size.
            //
            Console.SetWindowSize(origWidth, origHeight);
            Console.WriteLine(m1, Console.WindowWidth,
                                  Console.WindowHeight);

        }
    }
}
