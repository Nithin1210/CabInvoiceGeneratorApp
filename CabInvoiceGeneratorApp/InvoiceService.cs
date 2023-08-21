namespace CabInvoiceGeneratorApp
{

    public class InvoiceService
    {

        private readonly int costPerKilometer = 10;
        private readonly int minimumFare = 5;
        private readonly int costPerMinute = 1;

        public int NumOfRides
        {
            get
            {
                return this.NumOfRides;
            }
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
            double totalAmount = 0;
            foreach (var ride in rides)
            {
                totalAmount += ride.Distance * costPerKilometer + ride.Time * costPerMinute;
            }
            int numOfRides = rides.Length;
            double aggregateAmount = totalAmount / numOfRides;
            return aggregateAmount;

        }




    }

}