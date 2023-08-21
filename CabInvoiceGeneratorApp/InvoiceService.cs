namespace CabInvoiceGeneratorApp
{

    public class InvoiceService
    {

        private readonly int costPerKilometer = 10;
        private readonly int minimumFare = 5;
        private readonly int costPerMinute = 1;
        public int totalNumOfRides = 0;
        public double totalFare = 0;
        public double averageFare = 0;


        public int TotalNumOfRides()
        {
            return totalNumOfRides;
        }
        public double TotalFare()
        {
            return totalFare;
        }
        public double AverageFare()
        {
            return averageFare;
        }


        public double CalculateFare(double distance, double time)
        {
            double TotalAmount = distance * costPerKilometer + time * costPerMinute;
            if (TotalAmount > minimumFare)
            {
                return TotalAmount;
            }
            return minimumFare;
        }

        public double CalculateFare(Ride[] rides)
        {
            foreach (var ride in rides)
            {
                totalFare += ride.Distance * costPerKilometer + ride.Time * costPerMinute;
            }
            totalNumOfRides = rides.Length;
            averageFare = totalFare / totalNumOfRides;
            return averageFare;
        }

    }
}