using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem3
    {
        public Problem3()
        {
            List<int> primes = new List<int>();
            foreach (var item in MathHelper.Factors(600851475143))
            {
                if (MathHelper.IsPrime(item))
                {
                    primes.Add((int)item);
                }
            }
            Console.WriteLine(primes.Max());
        }
    }
}
