using System;
using System.Collections.Generic;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        private IEnumerable<object> weekends;

        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekends)
        {
            if (dayCount < 0)
            {
                throw new ArgumentException("day count can not be less than 0", nameof(dayCount));
            }

            var res = startDate;
            if (weekends is null)
            {
                res = startDate.AddDays(dayCount - 1);
                return res;
            }
            var deadlineDate = startDate.AddDays(dayCount);
            double nonWorkingDays;
            foreach (var item in weekends)
            {
                if (deadlineDate > item.StartDate)
                {
                    nonWorkingDays = (item.EndDate - item.StartDate).TotalDays;
                    res = startDate.AddDays(nonWorkingDays + dayCount);
                }
            }

            return res;
        }
    }
}
