namespace Taxi_Factory
{
    public class BusinessTaxiDriver : IDriver
    {
        private string _name;
        private double _rank;

        public (string, double) GetNameAndRank()
        {
            _name = "Volodimir";
            _rank = 5;
            return (_name, _rank);
        }
    }
}