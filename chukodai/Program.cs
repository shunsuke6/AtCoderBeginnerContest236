using System;
using System.Linq;
using System.Collections.Generic;
namespace chukodai
{
    class Program
    {
        static void Main(string[] args)
        {
            var S =Console.ReadLine().ToArray();
            int[] index = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var  a = S[index[0]-1];
            var b  = S[index[1]-1];
            
            S[index[0]-1] = b;
            S[index[1]-1] = a;
           
            Console.WriteLine(S);
        }
    }
}
