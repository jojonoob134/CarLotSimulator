using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Car
    {
        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            
        }
        public Car()
        {
            CarLot.NumOfCars++;
        }
        public int Year {  get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(Car cars)
        {
            Console.WriteLine($"The {cars.Make} makes a {cars.EngineNoise} noise in the engine");
        }
        public void MakeHonkNoise(Car cars)
        {
            Console.WriteLine($"The {cars.Make} makes a {cars.HonkNoise} noise in the homk's");
        }
    }
}
