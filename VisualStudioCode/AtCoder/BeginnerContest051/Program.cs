using System;

namespace BeginnerContest051
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer=0;

            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(input[0]);
            int s = int.Parse(input[1]);

            for(int i=0; i<=k; i++)
            {
                    for(int j=0; j<=k; j++)
                    {
                        if(0<=s-i-j && s-i-j<=k) answer++;
                    }
            }
            Console.WriteLine(answer);
        }
    }
}