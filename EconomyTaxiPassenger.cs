namespace Taxi_Factory
{
    public class EconomyTaxiPassenger : IPassenger
    {
        private string _name;
        private double _rank;

        public (string, double) GetNameAndRank()
        {
            _name = "Violet";
            _rank = 3;
            return (_name, _rank);
        }
    }
}