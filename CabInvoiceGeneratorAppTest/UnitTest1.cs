using CabInvoiceGeneratorApp;

namespace CabInvoiceGeneratorAppTest
{
    public class Tests
    {

        InvoiceService invoiceservice = new InvoiceService();
        [Test]
        public void GivenDistanceAndTime_WhenChecked_ReturnFareValue()
        {
            double actual = invoiceservice.CalculateFare("NORMAL", 10, 5);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRides_WhenChecked_ReturnTotalFare()
        {
            Ride[] ride =
            {
                new Ride(){Distance = 10,Time = 5,RideType = "NORMAL"}
            };
            double actual = invoiceservice.CalculateFare(ride);
            double expected = 105;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRides_WhenChecked_ReturnTotalRides()
        {
            Ride[] ride =
            {
                new Ride(){Distance = 10,Time = 5,RideType = "NORMAL" },
                new Ride(){Distance = 10,Time = 5,RideType = "PREMIUM"}
            };
            invoiceservice.CalculateFare(ride);
            int actual = invoiceservice.TotalNumOfRides();
            double expected = ride.Length;
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenRidesWithUserId_WhenChecked_ReturnTotalRides()
        {
            string userId = "abc";
            Ride[] ride =
            {
                new Ride(){Distance = 10,Time = 5, RideType = "NORMAL"}
            };
            RideRepository rideRepository = new RideRepository();
            rideRepository.AddRides(userId, ride);
            double actual = invoiceservice.CalculateFare(rideRepository.GetRides(userId));
            double expected = 105;
            Assert.AreEqual(actual, expected);  
        }
    }
}