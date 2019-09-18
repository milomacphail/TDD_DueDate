using System;
using NUnit.Framework;
using PaymentDateCheck;

namespace PaymentDateCheck
{
    public class TestFour
    {
        [Test]
        public void IfHolidayReturnWeekday()
        {
            var holiday = new HolidayService<IHolidayService>();
            DateTime holiDate = new DateTime(2018, 9, 20);
            var check = holiday.isHoliday(holiDate);
            bool weekDay = false;

            if (check == true)
            {
                DateTime nextDay = holiDate.AddDays(1);
                if(nextDay.DayOfWeek != DayOfWeek.Saturday || nextDay.DayOfWeek != DayOfWeek.Sunday)
                {
                    weekDay = true;   
                }
                else
                {
                    nextDay.AddDays(1);  
                }
            }


            Assert.AreEqual(check, weekDay);
        }
    }
}
   
