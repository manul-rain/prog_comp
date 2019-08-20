using System;

namespace ITP1_4_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');

            double min = Double.PositiveInfinity;
            double max = Double.NegativeInfinity;
            long sum=0;

            for(int i=0; i<n; i++)
            {
                if(min > long.Parse(str[i]))
                    min = long.Parse(str[i]);
            }

            for(int j=0; j<n; j++)
            {
                if(max < long.Parse(str[j]))
                    max = long.Parse(str[j]);
            }

            for(int k=0; k<n; k++)
            {
                sum += long.Parse(str[k]);
            }

            Console.WriteLine("{0} {1} {2}", min, max, sum);
        }
    }
}
