using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem9
    {
        public Problem9()
        {
            int limit = 1000;
            for (int numberOne = 0; numberOne < limit; numberOne++)
            {
                for (int numberTwo = 0; numberTwo < limit; numberTwo++)
                {
                    for (int numberThree = 0; numberThree < limit; numberThree++)
                    {
                        if(IsPythogareanTriplet(numberOne, numberTwo, numberThree) && (numberOne + numberTwo + numberThree == limit))
                        {
                            Console.WriteLine(String.Format("{0} * {1} * {2} = {3}", numberOne, numberTwo, numberThree, (numberOne * numberTwo * numberThree)));
                        }
                    }
                }
            }
       
        }

        public bool IsPythogareanTriplet(int numberOne, int numberTwo, int numberThree)
        {
            if(numberOne < numberTwo && numberTwo < numberThree)
            {
                if((numberOne * numberOne) + (numberTwo * numberTwo) == (numberThree * numberThree))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
