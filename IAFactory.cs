namespace Taxi_Factory
{
    public interface IAFactory
    {
        ICar CreateCar();
        IDriver CreateDriver();
        IPassenger CreatePasseger();
    }
}