using System;
using System.Numerics;

namespace BOJ_2338
{
    internal static class MainApp
    {
        private static void Main(string[] args)
        {
            var l1 = Console.ReadLine();
            var l2 = Console.ReadLine();

            var a = BigInteger.Parse(l1);
            var b = BigInteger.Parse(l2);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
        }
    }
}