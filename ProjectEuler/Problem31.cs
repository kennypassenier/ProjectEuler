using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem31
    {
        public int Target = 200;
        public int[] CoinSizes = {1, 2, 5, 10, 20, 50, 100, 200};
        public int[] Ways;

        public int Result => Ways[Ways.Length - 1];

        public Problem31()
        {
            Ways = new int[Target + 1];
            Ways[0] = 1;
            CalculateResult();
            Console.WriteLine(Result);
        }

        public void CalculateResult()
        {
            for (var i = 0; i < CoinSizes.Length; i++)
            {
                for (var j = CoinSizes[i]; j <= Target; j++)
                {
                    Ways[j] += Ways[j - CoinSizes[i]];
                }
            }
        }
    }
}
