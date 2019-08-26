using System;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            Console.WriteLine(string.Compare(str[0], str[1]));
        }
    }
}
