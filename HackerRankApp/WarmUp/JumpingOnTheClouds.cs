using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.WarmUp
{
    public class JumpingOnTheClouds
    {
        public int CountJumps(int[] clouds)
        {
            var jumps = 0;

            for (int i = 0; i < clouds.Length-1; i++,jumps++)
            {
                if (i < clouds.Length - 2 && clouds[i + 2] == 0)
                    i++;
            }

            return jumps;
        }
    }
}
