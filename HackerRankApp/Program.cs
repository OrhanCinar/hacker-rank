using HackerRankApp.WarmUp;
using System;

namespace HackerRankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = new CountingValleys();
            var t = C.CountValley(8, "UDDDUDUU");
            Console.WriteLine(t);


            Console.ReadKey();
        }
    }
}
