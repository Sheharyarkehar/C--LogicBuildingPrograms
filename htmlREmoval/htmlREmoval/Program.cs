using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace htmlREmoval
{
    class Program
    {
        static void Main(string[] args)
        {
            const string source = "<p>There was a <b>.NET</b> programmer " +
            "and he stripped the <i>HTML</i> tags.</p>";
            
               char[] array = new char[source.Length];
        int arrayIndex = 0;
        bool inside = false;

        for (int i = 0; i < source.Length; i++)
        {
            char let = source[i];
            if (let == '<')
            {
                inside = true;
                continue;
            }
            if (let == '>')
            {
                inside = false;
                continue;
            }
            if (!inside)
            {
                array[arrayIndex] = let;
                arrayIndex++;
            }
        }
        for (int i = 0; i <array.Length; i++)
        {
            Console.Write(array[i]);
        }

        }
    }
}
