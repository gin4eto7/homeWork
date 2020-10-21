using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < num; i++)
            {
                string[] carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                List<double> tirePressure = new List<double>();
                List<int> tireAge = new List<int>();

                for (int j = 5; j < carInfo.Length; j += 2)
                {
                    double tirePre = double.Parse(carInfo[j]);
                    int tireAg = int.Parse(carInfo[j + 1]);
                    tirePressure.Add(tirePre);
                    tireAge.Add(tireAg);
                }


                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);


                Tire tire = new Tire(tirePressure, tireAge);

                Car car = new Car(model, engine, cargo, tire);

                cars.Add(car);
            }
            

            string command = Console.ReadLine();
            
            if(command == "fragile")
            {
                var listOfCars = cars.Where(x => x.Cargo.CargoType == "fragile" && x.Tire.TiresPressure.Any(y => y < 1)).ToList();
                foreach (var car in listOfCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if(command == "flamable")
            {
                var listOfCars = cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
                foreach (var car in listOfCars)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
