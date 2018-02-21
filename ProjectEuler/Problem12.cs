using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace ProjectEuler
{
    public class Problem12
    {
        public Problem12()
        {
            // When limit = 5 (as per example on project euler) it appears to give the wrong answer, but it works for limit = 500?
            int limit = 500;
            int counter = 1;
            while (MathHelper.Factors(MathHelper.TriangleNumber(counter)).Count <= limit)
            {
                counter++;
            }
            Console.WriteLine(MathHelper.TriangleNumber(counter));
        }

        
    }
}
