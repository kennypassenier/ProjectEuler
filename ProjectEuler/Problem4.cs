using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem4
    {
        public Problem4()
        {
            List<int> palindromes = new List<int>();
            int limit = 1000;
            for (int numberOne = 1; numberOne < limit; numberOne++)
            {
                for (int numberTwo = 1; numberTwo < limit; numberTwo++)
                {
                    int possiblePalindrome = numberOne * numberTwo;
                    if (MathHelper.IsPalindrome(possiblePalindrome))
                    {
                        palindromes.Add(possiblePalindrome);
                    }
                }
            }
            Console.WriteLine(palindromes.Max());
        }
    }
}
