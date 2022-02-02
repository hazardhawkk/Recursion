using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            RecursiveReverseString("Trees are cool"); 
        }
        static int RecursiveFactorial(int n)
        {
            if(n <= 1)
            {
                return 1;
            }
            else
            {
                return n* RecursiveFactorial(n-1);
            }

        }

        static void RecursiveReverseString(string str)  
        {
            if (str.Length <= 1)        //this is barely my own code but i understood it
            {
                Console.Write(str);
            } else
            {
                Console.Write(str[str.Length - 1]);
                RecursiveReverseString(str.Substring(0, str.Length - 1));
            }
        }
    }
}
