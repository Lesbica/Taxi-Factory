namespace Taxi_Factory
{
    public class BusinessTaxiPassenger : IPassenger
    {
        private string _name;
        private double _rank;

        public (string, double) GetNameAndRank()
        {
            _name = "Maria";
            _rank = 6;
            return (_name, _rank);
        }
    }
}