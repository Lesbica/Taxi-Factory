using System;

namespace Taxi_Factory
{
    public class EconomyTaxiCar : ICar
    {
        private string _markCar;

        public string CreateCar()
        {
            Random random = new Random();
            string[] cars = { "Chavrolet Lacetti", "Chavrolet Aveo", "Renault Logan", "Skoda Fabia" };
            int randomNumber = random.Next(0, 3);
            _markCar = cars[randomNumber];
            return _markCar;
        }
    }
}