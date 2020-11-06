using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automata8
{
    class Program
    {
        static void Main(string[] args)
        {
            int states=0;
            int check = 0;
            int c_state = 0; int count = 0;
	string inp;
	int [,]t=new int[5,2]{{1,0},{1,2},{1,3},{4,0},{1,0}};
Console.WriteLine("Enter String:");
	inp=Console.ReadLine();
    char[] x = inp.ToCharArray();
		for(int i=0;i<inp.Length;i++){
				char ch=x[i];
				if(ch=='a'){
					check=0;
				}
				else if(ch=='b'){
					check=1;
				}
				c_state=t[c_state,check];
				if(c_state==4){
					count++;				
			}		
		}
	Console.WriteLine("Total occurence of abba in a given string is={0}",count);
	


        }
    }
}
