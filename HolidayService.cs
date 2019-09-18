using System;
using System.Collections.Generic;

namespace PaymentDateCheck
{
    public class HolidayService<T> : IHolidayService
    {
        public bool isHoliday (DateTime dueDate)
        {
            var holidays = new List<DateTime>();
            holidays.Add(new DateTime(2019,12,25));
            holidays.Add(new DateTime(2019,8,3));
            if(holidays.Contains(dueDate))
                return true;

            return false;
        }
    }
}