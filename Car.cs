using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            Weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            Color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            : this(model, engine)
        {
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int ? Weight  { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            string weightString = this.Weight.HasValue ? 
                this.Weight.ToString() : "n/a";
            string colorString = String.IsNullOrEmpty(this.Color) ?
                "n/a" : this.Color;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Model}:")
              .AppendLine($"  {Engine}")
              .AppendLine($"  Weight: {weightString}")
              .AppendLine($"  Color: {colorString}");

            return sb.ToString().TrimEnd(); 
        }
    }
}
