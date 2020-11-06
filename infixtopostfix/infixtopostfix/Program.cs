using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infixtopostfix
{
    class Program
    {
       static Boolean isOperand(char x) 
{ 
    return (x >= 'a' && x <= 'z') || 
            (x >= 'A' && x <= 'Z'); 
} 
  
// Get Infix for a given postfix 
// expression 
static String getInfix(String exp) 
{ 
    Stack <string>s= new Stack<string>(); 
  
    for (int i = 0; i < exp.Length; i++) 
    { 
        // Push operands 
        if (isOperand(exp[i])) 
        { 
            s.Push(exp[i] + ""); 
        } 
  
        // We assume that input is 
        // a valid postfix and expect 
        // an operator. 
        else
        { 
            String op1 = (String) s.Peek(); 
            s.Pop(); 
            String op2 = (String) s.Peek(); 
            s.Pop(); 
            s.Push("(" + op2 + exp[i] + 
                    op1 + ")"); 
        } 
    } 
  
    // There must be a single element 
    // in stack now which is the required 
    // infix. 
    return (String)s.Peek(); 
} 
  
// Driver code 
public static void Main(String []args) 
{
    String exp = Console.ReadLine();
    Console.WriteLine( getInfix(exp)); 
} 
} 
    }

