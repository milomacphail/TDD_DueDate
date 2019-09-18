using NUnit.Framework;
using PaymentDateCheck;
using System;
using System.Collections.Generic;

namespace Tests
{    
    [TestFixture]
    public class BillShould
    {
        [Test]
        public void ifBussinessDay_ReturnDueDate()
        {
            var input = new DateTime(2019,9,17);
            var mockHolidayService = new HolidayService <IHolidayService>();
            var _bill = new Bill(mockHolidayService);
            var output = _bill.CheckDate(input);
            var expected = input;
            Assert.AreEqual(expected, output);
        }
    }
}