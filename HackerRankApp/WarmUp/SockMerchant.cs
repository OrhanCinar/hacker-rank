using System.Collections.Generic;

namespace HackerRankApp.WarmUp
{
    public class SockMerchant
    {
        public int PairSocks(int count, int[] socks)
        {
            var dic = new Dictionary<int, int>();

            foreach (var sock in socks)
            {
                if (dic.ContainsKey(sock))
                {
                    var value = 0;
                    var item = dic.TryGetValue(sock, out value);
                    dic[sock] = ++value;
                }
                else
                {
                    dic.Add(sock, 1);
                }
            }

            var pairCount = 0;

            foreach (var item in dic)
            {
                var totalPairs = item.Value % 2;

                if (totalPairs == 0)
                {
                    pairCount += item.Value / 2;
                }
                else
                {
                    var evenPair = item.Value / 2;

                    pairCount += evenPair;
                }
            }

            return pairCount;
        }
    }
}