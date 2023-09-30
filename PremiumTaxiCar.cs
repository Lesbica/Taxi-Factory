using System;

namespace Taxi_Factory
{
    public class PremiumTaxiCar : ICar
    {
        private string _markCar;

        public string CreateCar()
        {
            Random random = new Random();
            string[] cars = { "Lexus LX", "Mercedes-Benz S-class", "Renault Logan", "Mercedes-Benz G-class" };
            int randomNumber = random.Next(0, 3);
            _markCar = cars[randomNumber];
            return _markCar;
        }
    }
}