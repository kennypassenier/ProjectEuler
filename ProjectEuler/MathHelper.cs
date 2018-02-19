using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class MathHelper
    {
        // Checks if the number is a valid palindrome (Ex: 515 == true, 5515 == false).
        public static bool IsPalindrome(int number)
        {
            string numberAsString = number.ToString();
            // Requires System.Linq to work. 
            return numberAsString.SequenceEqual(numberAsString.Reverse());
        }

        // Returns a list of factors. Including the number itself. 
        public static List<int> Factors(int number, bool ordered = false)
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
            if (ordered)
            {
                factorList.Sort();
            }
            return factorList;
        }
    }
}
