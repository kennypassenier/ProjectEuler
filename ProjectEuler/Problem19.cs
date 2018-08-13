using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class Problem19
    {
        private DateTime _startDateValue = new DateTime(1901, 01, 01);
        private readonly DateTime _endDateValue = new DateTime(2000, 12, 31);
        private int _intervalValue = 1;
        private int _counter;
        public Problem19()
        {
            CountSundays();
        }
        private void CountSundays()
        {
            
            while(_startDateValue.AddDays(_intervalValue) <= _endDateValue)
            {
                if (_startDateValue.DayOfWeek == DayOfWeek.Sunday)
                    if (_startDateValue.Day == 1)
                        _counter += 1;
                Console.WriteLine($"De teller staat op: {_counter}");
                _startDateValue = _startDateValue.AddDays(_intervalValue);
                
            }
            Console.WriteLine(_counter);
        }
    }
}
