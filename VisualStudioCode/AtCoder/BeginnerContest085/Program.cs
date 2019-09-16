using System;

namespace BeginnerContest085
{
    class Program
    {
        static void Main(string[] args)
        {
            bool find_flag = false;
        
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]);
            int Y = int.Parse(input[1]);

            for(int i=0; i<=N; i++)
            {
                for(int j=0; j<=N; j++)
                {
                    if((i*10000+j*5000+(N-i-j)*1000 == Y) && (N-i-j >= 0) )
                    {
                        Console.WriteLine("{0} {1} {2}",i, j, N-i-j);
                        find_flag = true;
                    }
                    if(find_flag == true) break;
                }
                if(find_flag == true) break;
            }
            if(find_flag == false) Console.WriteLine("-1 -1 -1");
        }
    }
}
