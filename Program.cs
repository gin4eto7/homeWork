using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArraysLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

            SortedDictionary<double, int> count = new SortedDictionary<double, int>();

            foreach (var num in nums)
            {
                if(count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count.Add(num, 1);
                }
            }
            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }

    }
}
