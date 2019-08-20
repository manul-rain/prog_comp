using System;

namespace ITP1_5_B
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

                if(W!=0 && H!=0)
                {
                    for(int i=0; i<H; i++)
                    {
                        for(int j=0; j<W; j++)
                        {
                            if(j==W-1)
                            {
                                Console.WriteLine('#');
                            }
                            else if(i==0 || i==H-1 || j==0) 
                            {
                                Console.Write('#');
                            }
                            else
                            {
                                Console.Write('.');
                            }
                        }
                    }

                    Console.WriteLine();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
