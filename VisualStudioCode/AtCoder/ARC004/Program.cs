using System;
using System.Linq;
using System.Collections.Generic;

namespace ARC004
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------------------------
            //copy the code of "takumioda" in AtCoder
            //------------------------------------------
            x
            var N = int.Parse(Console.ReadLine());

            List<int> xList = new List<int>();
            List<int> yList = new List<int>();
            for(int i=0; i<N; i++)
            {
                var tmp = Console.ReadLine().Split(' ');
                xList.Add(int.Parse(tmp[0]));
                yList.Add(int.Parse(tmp[1]));            
            }

            double result = 0;
            for(int i=0; i<N; i++)
            {
                var baseX = xList[i];
                var baseY = yList[i];

                for(int j=i+1; j<N; j++)
                {
                    var otherX = xList[j];
                    var otherY = yList[j];
                    var distance = Math.Sqrt(Math.Pow(otherX - baseX, 2) 
                                                + Math.Pow(otherY - baseY, 2));

                    if(distance > result)
                    {
                        result = distance;
                    }
                }
            }
            Console.Write(result);
        }
    }
}
