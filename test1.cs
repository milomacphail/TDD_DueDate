using System;
using NUnit.Framework;

namespace PaymentDateCheck
{
    class Test1
    {
        [Test]
        public void ifSaturday_ReturnMonday()
        {
            DateTime dueDate = new DateTime(2019, 9, 21);
            DateTime mondayDue = new DateTime(2019, 9, 23);

            if (dueDate.DayOfWeek == DayOfWeek.Saturday)
            {
                DateTime monday = dueDate.AddDays(2);
                dueDate = monday;
            }
            Assert.AreEqual(dueDate, mondayDue);
        }

    }
}