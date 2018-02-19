using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem6
    {
        public Problem6()
        {
            int limit = 100;
            int sumSquare = 0;
            int squareSum = 0;
            // Sum of the squares        
            for (int number = 1; number <= limit; number++)
            {
                sumSquare += number * number;
            }
            // Square of the sum
            for (int number = 1; number <= limit; number++)
            {
                squareSum += number;
            }
            squareSum = squareSum * squareSum;

            Console.WriteLine(String.Format("The answer is: {0}", squareSum - sumSquare));
        }
    }
}
