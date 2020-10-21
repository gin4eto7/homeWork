using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> listOfEngine = new List<Engine>();
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] infoEngine = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = infoEngine[0];
                int power = int.Parse(infoEngine[1]);
                int displacement;
                string efficiency;

                Engine engine = null;

                if (infoEngine.Length == 2)
                {
                    engine = new Engine(model, power);
                    listOfEngine.Add(engine);
                }
                else if (infoEngine.Length == 3)
                {
                    bool isDisplacement = int.TryParse(infoEngine[2], out displacement);

                    if(isDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, infoEngine[2]);
                    }
                    
                }
                else if(infoEngine.Length == 4)
                {
                    displacement = int.Parse(infoEngine[2]);
                    efficiency = infoEngine[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }

                listOfEngine.Add(engine);
            }

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] infoCar = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = infoCar[0];
                Engine engine = listOfEngine.Where(x => x.Model == infoCar[1]).FirstOrDefault();
                int weight;
                string color;

                Car car = null;
                if(infoCar.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if(infoCar.Length == 3)
                {
                    bool isWeight = int.TryParse(infoCar[2], out weight);

                    if(isWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        color = infoCar[2];
                        car = new Car(model, engine, color);
                    }
                }
                else if(infoCar.Length == 4)
                {
                    weight = int.Parse(infoCar[2]);
                    color = infoCar[3];
                    car = new Car(model, engine, weight, color);
                }
                listOfCars.Add(car);
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine(car);
            }         
            
        }

    }
}
