using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automata5
{
    class Program
    {
        

    static void CombinationRepetitionUtil(int []chosen, char []arr,  
            int index, int r, int start, int end) {  
         
        if (index == r) {  
            for (int i = 0; i < r; i++) {  
                Console.Write(arr[chosen[i]]+" ");  
            }  
            Console.WriteLine();  
            return;  
        }  
  
 
        for (int i = start; i <= end; i++) {  
            chosen[index] = i;  
            CombinationRepetitionUtil(chosen, arr, index + 1,  
                    r, i, end);  
        }  
        return;  
    }  

    static void CombinationRepetition(char []arr, int n, int length) {  
  
        int []chosen = new int[length + 1];  
  
        CombinationRepetitionUtil(chosen, arr, 0, length, 0, n - 1);  
    }  
  

    public static void Main() {
        //Console.WriteLine("Enter alphabet:");
        //string a = Console.ReadLine();
        char[] arr ={'a','b'};
        int n = arr.Length;
        Console.WriteLine("Enter length of combinations");
        int length = int.Parse(Console.ReadLine());  
        CombinationRepetition(arr, n, length);  
    }  
}  
  
    }
