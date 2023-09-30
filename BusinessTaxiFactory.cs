namespace Taxi_Factory
{
    public class BusinessTaxiFactory : IAFactory
    {
        public ICar CreateCar()
        {
            return new BusinessTaxiCar();
        }

        public IDriver CreateDriver()
        {
            return new BusinessTaxiDriver();
        }
        
        public IPassenger CreatePasseger()
        {
            return new BusinessTaxiPassenger();
        }
    }
}