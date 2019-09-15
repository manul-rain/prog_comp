using System;
using System.Linq;

namespace prac
{
    class Program
    {
        static void Main(string[] args)
        {
            var linqtype = Console.ReadLine()
                    .Split(' ')
                    .Select(x => int.Parse(x));

            var arraytype = Console.ReadLine().Split(' ');
            var n = int.Parse(arraytype[0]);

            var parsetype = int.Parse(Console.ReadLine());

            Console.WriteLine(linqtype.GetType());
            Console.WriteLine(linqtype.ToArray().GetType());
            Console.WriteLine(n.GetType());
            Console.WriteLine(parsetype.GetType());
        }
    }
}
