using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public Engine(string model, int power, int displacement)
            :this(model, power)
        {
            Displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            :this(model, power)
        {
            Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            :this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;

        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int ? Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string displacementString = this.Displacement.HasValue ?
                this.Displacement.ToString() : "n/a";
            string efficiencyString = String.IsNullOrEmpty(this.Efficiency) ?
                "n/a" : this.Efficiency;

            sb.AppendLine($"{Model}:")
                .AppendLine($"    Power: {Power}")
                .AppendLine($"    Displacement: {displacementString}")
                .AppendLine($"    Efficiency: {efficiencyString}");

            return sb.ToString().TrimEnd(); 
        }
    }
}
