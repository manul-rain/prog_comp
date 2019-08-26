using System;

namespace ITP1_5_C
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] str = Console.ReadLine().Split(' ');
                int H = int.Parse(str[0]);
                int W = int.Parse(str[1]);

                if(H==0 || W==0) break;

                for(int i=0; i<H; i++)
                {
                    for(int j=0; j<W; j++)
                    {
                        if((i%2==0 && j%2==0) || (i%2==1 && j%2==1) )
                        {
                            Console.Write('#');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            
        }
    }
}
