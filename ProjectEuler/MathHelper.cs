using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class MathHelper
    {
        public static bool IsPalindrome(int number)
        {
            string numberAsString = number.ToString();
            // Requires System.Linq to work. 
            return numberAsString.SequenceEqual(numberAsString.Reverse());
        }

        public static List<int> Factors(int number)
        {
            List<int> factorList = new List<int>();
            int limit = (int)Math.Sqrt(number) + 1;
            for (int possibleFactor = 1; possibleFactor <= limit; possibleFactor++)
            {
                if (number % possibleFactor == 0)
                {
                    factorList.Add(possibleFactor);
                    factorList.Add(number / possibleFactor);
                }
            }
            return factorList;
        }
    }
}
