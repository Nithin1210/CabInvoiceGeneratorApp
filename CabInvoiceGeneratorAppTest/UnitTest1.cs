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

    }
}