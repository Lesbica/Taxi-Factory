namespace Taxi_Factory
{
    public class EconomyTaxiFactory : IAFactory
    {
        public ICar CreateCar()
        {
            return new EconomyTaxiCar();
        }

        public IDriver CreateDriver()
        {
            return new EconomyTaxiDriver();
        }
        
        public IPassenger CreatePasseger()
        {
            return new EconomyTaxiPassenger();
        }
    }
}