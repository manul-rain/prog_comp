using System;

namespace ITP1_4_C
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while(true)
            {
                int result = 0;
                string[] input = Console.ReadLine().Split(' ');
                int a = int.Parse(input[0]);
                int b = int.Parse(input[2]);
                string op = input[1];

                if(op == "+") result = a + b;
                else if(op == "-") result = a - b;
                else if(op == "*") result = a * b;
                else if(op == "/") result = a / b;
                else Environment.Exit(0);

                Console.WriteLine(result);
            }
        }
    }
}
