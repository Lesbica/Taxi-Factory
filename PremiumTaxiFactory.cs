namespace Taxi_Factory
{
    public class PremiumTaxiFactory : IAFactory
    {
        public ICar CreateCar()
        {
            return new PremiumTaxiCar();
        }

        public IDriver CreateDriver()
        {
            return new PremiumTaxiDriver();
        }
        
        public IPassenger CreatePasseger()
        {
            return new PremiumTaxiPassenger();
        }
    }
}