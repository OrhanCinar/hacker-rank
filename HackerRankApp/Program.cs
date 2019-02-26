using HackerRankApp.Warmup;
using System;

namespace HackerRankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = new SockMerchant();
            var socks = new[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            var t = C.PairSocks(10, socks);
            Console.WriteLine(t);


            Console.ReadKey();
        }
    }
}
