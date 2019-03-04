using HackerRankApp.WarmUp;
using System;

namespace HackerRankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var C = new RepeatedString();
            var t = C.CountString("aba", 20);
            Console.WriteLine(t);


            Console.ReadKey();
        }
    }
}
