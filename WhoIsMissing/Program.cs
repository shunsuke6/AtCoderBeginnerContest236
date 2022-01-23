using System;
using System.Linq;

namespace WhoIsMissing
{
    class Program
    {
        static void Main(string[] args)
        {

            long N = long.Parse(Console.ReadLine());
            long[] card = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var sumCard = N * (1 + N) * 2;
            Console.WriteLine(sumCard - card.Sum());


        }
    }
}
