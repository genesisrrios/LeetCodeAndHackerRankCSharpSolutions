using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class SalesMerchant
    {
        public static int SockMerchant(int n, int[] ar)
        {
            var numberOfPairs = 0;
            var distinctSock = ar.Distinct().ToArray();

            for (int i = 0; i < distinctSock.Length; i++)
            {
                var count = ar.Where(x => x == distinctSock[i]).Count();

                if (count == 2)
                    numberOfPairs++;
                else
                {
                    var number = count / 2;
                    numberOfPairs = numberOfPairs + number;
                }

            }

            return numberOfPairs;
        }
    }
}
