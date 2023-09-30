using System;

namespace Taxi_Factory
{
    public class BusinessTaxiCar : ICar
    {
        private string _markCar;

        public string CreateCar()
        {
            var random = new Random();
            string[] cars = { "Toyota Camry", "Mercedes-Benz E-class"};
            int randomNumber = random.Next(0, 1);
            _markCar = cars[randomNumber];
            return _markCar;
        }
    }
}