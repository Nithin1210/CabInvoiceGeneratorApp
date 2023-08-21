using CabInvoiceGeneratorApp;

namespace CabInvoiceGeneratorAppTest
{
    public class Tests
    {

        [Test]
        public void GivenDistanceAndTimeWhenCheckedReturnFareValue()
        {
            InvoiceService invoiceservice = new InvoiceService();
            double actual = invoiceservice.CalculateFare(10, 5);
            double expected = 105;
            Assert.AreEqual(actual, expected);

        }

    }
}