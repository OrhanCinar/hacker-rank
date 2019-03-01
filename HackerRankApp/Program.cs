using HackerRankApp.WarmUp;
using System;

namespace HackerRankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = new JumpingOnTheClouds();
            var t = C.CountJumps(new []{ 0, 0, 0, 0, 1, 0});
            Console.WriteLine(t);


            Console.ReadKey();
        }
    }
}
