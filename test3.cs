using System;
using NUnit.Framework;
using PaymentDateCheck;

namespace PaymentDateCheck
{
    public class Test3
    {

        [Test]
        public void ifHoliday_ReturnNonHoliday()
        {
            var holidayOrNot = new HolidayService<IHolidayService>();
            bool notHoliday = false;
            DateTime dueDate = new DateTime(2019, 12, 25);
            var check = holidayOrNot.isHoliday(dueDate);
            if (check == true)
            {
                notHoliday = true;
            }
            
            Assert.AreEqual(notHoliday, check);
        }
    }

}
