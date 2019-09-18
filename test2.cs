using System;
using NUnit.Framework;

namespace PaymentDateCheck
{

    public class TestTwo
    {
        [Test]
        public void IfSundayReturnMonday()
        {
            DateTime billDate = new DateTime(2019, 8, 11);
            DateTime dueDate = new DateTime(2019, 8, 12);

            if (billDate.DayOfWeek == DayOfWeek.Sunday)
            {
                DateTime monday = billDate.AddDays(1);
                billDate = monday;
            }


            Assert.AreEqual(billDate, dueDate);
        }
    }
}
   