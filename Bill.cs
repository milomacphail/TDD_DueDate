using System;
using NUnit.Framework;


namespace PaymentDateCheck
{
    public class Bill
    {
        //bring in holiday service to check for holidays
        //use dependency injection
        public Bill(IHolidayService service)
        {

        }

        public Bill(DateTime duedate)
        {
        
        }

        public DateTime CheckDate(DateTime dueDate)
        {
            return dueDate;
        }

    }
}

