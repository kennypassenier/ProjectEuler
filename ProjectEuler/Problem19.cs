using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem19
    {
        private DateTime startDateValue = new DateTime(1901, 01, 01);
        private readonly DateTime endDateValue = new DateTime(2000, 12, 31);
        private int intervalValue = 1;
        private int counter;
        public Problem19()
        {
            CountSundays();
        }
        private void CountSundays()
        {
            
            while(startDateValue.AddDays(intervalValue) <= endDateValue)
            {
                if (startDateValue.DayOfWeek == DayOfWeek.Sunday)
                    if (startDateValue.Day == 1)
                        counter += 1;
                Console.WriteLine($"De teller staat op: {counter}");
                startDateValue = startDateValue.AddDays(intervalValue);
                
            }
            Console.WriteLine(counter);
        }
    }
}
