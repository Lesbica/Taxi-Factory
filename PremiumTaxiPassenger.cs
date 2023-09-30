namespace Taxi_Factory
{
    public class PremiumTaxiPassenger : IPassenger
    {
        private string _name;
        private double _rank;

        public (string, double) GetNameAndRank()
        {
            _name = "Vivian";
            _rank = 9.5;
            return (_name, _rank);
        }
    }
}