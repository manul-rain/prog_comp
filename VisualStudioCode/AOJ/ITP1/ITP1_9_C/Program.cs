using System;

namespace ITP1_9_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int Taro=0, Hanako=0;

            // int n = int.Parse(Console.ReadLine());

            // for(int i=0; i<n; i++)
            // {
                string[] cards = Console.ReadLine().Split(' ');
                Array.Sort(cards);

                Console.WriteLine("{0} {1}",cards[0],cards[1]);
            // }
        }
    }
}
