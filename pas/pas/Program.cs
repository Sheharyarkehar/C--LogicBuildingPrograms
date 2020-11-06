using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pas
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,k,ncr,fs,fr,fn,fs1,fr1,fn1;
        Console.Write("Enter no of rows");
        int nor = Convert.ToInt32(Console.ReadLine());
	for(i=0;i<=nor;i++)
	{ 
		for(k=0;k<=(nor-i);k++)
		{
				Console.Write(" ");
			}

		for(j=0;j<=i;j++)
	{
        fn = 1; fs = 1; fr = 1;
			for(fn1=1;fn1<=i;fn1++)
	{
	   fn=fn*fn1;
            
             }
	   
        for(fr1=1;fr1<=j;fr1++)
        {
        	fr=fr*fr1;
		}
		
		for(fs1=1;fs1<=i-j;fs1++)
		{
			fs=fs*fs1;
		}
		ncr=fn/(fs*fr);
		Console.Write(" "+ncr);

	}
	Console.WriteLine();
}
        }
    }
} 
