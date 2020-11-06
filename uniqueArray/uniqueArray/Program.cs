using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uniqueArray
{
    class Program
    {
        static void Main(string[] args)
        {
            	int []arr=new int[12]{1,4,2,1,6,1,2,3,5,4,8,6};

                int i, j, k;
	for(i=0;i<arr.Length;i++){
		for(j=0;j<arr.Length;j++)
		{
			if(arr[i]==arr[j]){
                for (k = j; k < arr.Length; k++)
                {
                    arr[k+1] = arr[k];
                    arr[k] = 0;
                   
                }
			}
		
			
			
		}
		
	}
	for(i=0;i<arr.Length;i++){
		Console.WriteLine(arr[i]);
		}
        }
    }
}
