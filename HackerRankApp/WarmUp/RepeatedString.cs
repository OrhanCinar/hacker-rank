using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankApp.WarmUp
{
    public class RepeatedString
    {
        public long CountString(string input, long count)
        {
            long totalCount = 0;
            var countForSub = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a') countForSub++;
            }


            long divisor = count / input.Length;

            totalCount += divisor * countForSub;

            long remainder = count % input.Length;


            for (int i = 0; i < remainder; i++)
            {
                if (input[i] == 'a')
                    totalCount++;
            }

            return totalCount;
        }
    }
}
