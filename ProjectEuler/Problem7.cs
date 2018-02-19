using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem7
    {
        public Problem7()
        {
            int limit = 10001;
            int nrOfFoundPrimes = 1; // Dan kunnen we beginnen met 3 en telkens + 2
            for (int potentialPrime = 3; nrOfFoundPrimes < limit; potentialPrime += 2)
            {
                if (MathHelper.IsPrime(potentialPrime))
                {
                    nrOfFoundPrimes++;
                    Console.WriteLine(String.Format("{0} is the {1}th prime number", potentialPrime, nrOfFoundPrimes));
                }
            }
        }
    }
}
