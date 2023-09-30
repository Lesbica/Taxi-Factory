namespace Taxi_Factory
{
    public class EconomyTaxiDriver : IDriver
    {
        private string _name;
        private double _rank;

        public (string, double) GetNameAndRank()
        {
            _name = "John";
            _rank = 2.4;
            return (_name, _rank);
        }
    }
}