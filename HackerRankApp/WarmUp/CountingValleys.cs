using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.WarmUp
{
    public class CountingValleys
    {
        public int CountValley(int steps, string path)
        {
            int valley = 0;

            int level = 0;

            foreach (var item in path)
            {
                if (item == 'U') ++level;
                if (item == 'D') --level;

                if (level == 0 && item == 'U')
                    ++valley;
            }

            return valley;
        }
    }
}
