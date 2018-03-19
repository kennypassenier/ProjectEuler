using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
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

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                int limit = (int)Math.Sqrt(number) + 1;
                for (int possiblePrime = 3; possiblePrime <= limit; possiblePrime++)
                {
                    if (number % possiblePrime == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        // Returns a list of factors. Including the number itself. 
        public static List<long> Factors(long number, bool ordered = false)
        {
            List<long> factorList = new List<long>();
            long limit = (long)Math.Sqrt(number) + 1;
            for (long possibleFactor = 1; possibleFactor <= limit; possibleFactor++)
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

        public static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            else if (number % 2 == 0)
            {
                return false;
            }
            else
            {
                int limit = (int)Math.Sqrt(number) + 1;
                for (int possiblePrime = 3; possiblePrime < limit; possiblePrime++)
                {
                    if ((number % possiblePrime) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }


        public static List<int> PrimeFactors(int number)
        {
            List<int> factoren = Factors(number);
            foreach (var item in factoren)
            {
                if (IsPrime(item) == false)
                {
                    factoren.Remove(item);
                }
            }
            return factoren;
        }

        public static bool IsEvenlyDivisible(int number, int limit)
        {
            for (int divisor = 1; divisor < limit + 1; divisor++)
            {
                if (number % divisor != 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsEvenlyDivisible(long number, long limit)
        {
            for (long divisor = 1; divisor < limit + 1; divisor++)
            {
                if (number % divisor != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int TriangleNumber(int number)
        {
            int result = 0;
            for (int counter = 1; counter <= number; counter++)
            {
                result += counter;
            }
            return result;
        }

        // De factorials werken in principe wel, maar blijkbaar gaat er toch ergens nog iets
        // fout want Problem20 van Project Euler werkt nog altijd niet.

        //public static int Factorial(int number)
        //{
        //    if (number == 1)
        //        return 1;
        //    else
        //        return number * Factorial(number - 1);
        //}
        //public static long Factorial(long number)
        //{
        //    if (number == 1)
        //        return 1;
        //    else
        //        return number * Factorial(number - 1);
        //}
        //public static BigInteger Factorial(int number)
        //{
        //    if (number == 1)
        //        return 1;
        //    else
        //        return number * Factorial(number - 1);
        //}
    }
}
