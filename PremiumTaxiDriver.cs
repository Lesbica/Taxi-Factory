namespace Taxi_Factory
{
    public class PremiumTaxiDriver : IDriver
    {
        private string _name;
        private double _rank;

        public (string, double) GetNameAndRank()
        {
            _name = "Oleg";
            _rank = 10;
            return (_name, _rank);
        }
    }
}