using CabInvoiceGeneratorApp;

namespace CabInvoiceGeneratorAppTest
{
    public class Tests
    {
        InvoiceService invoiceservice = new InvoiceService();

        [Test]
        public void GivenDistanceAndTimeWhenCheckedReturnFareValue()
        {
            double actual = invoiceservice.CalculateFare(10, 5);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenRides_WhenChecked_ReturnTotalFare()
        {
            Ride[] ride =
            {
                new Ride (){Distance =10 ,Time=5}
            };
            double actual = invoiceservice.CalculateFare(ride);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }


    }
}