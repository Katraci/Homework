using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Travel_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Dictionary<string, long> > cityVehicle = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();
            while (input!= "ready")
            {
                string[] inputCityVehicle= input.Split(':').ToArray();
                string city = inputCityVehicle[0];
                if (!cityVehicle.ContainsKey(city))
                {
                    cityVehicle[city] = new Dictionary<string, long>();
                }
                string[] vehicleCapacity = inputCityVehicle[1].Split(',').ToArray();
                foreach (string item in vehicleCapacity)
                {
                    string[] token = item.Split('-').ToArray();
                    string vehicle = token[0];
                    long capacity = long.Parse(token[1]);
                    cityVehicle[city][vehicle] = capacity;
                }
                 input = Console.ReadLine();
            }
            Dictionary<string, long> groups = new Dictionary<string, long>();
            input = Console.ReadLine();
            while (input!= "travel time!")
            {
                string[] cityComers = input.Split(' ').ToArray();
                string city = cityComers[0];
                long group = long.Parse(cityComers[1]);
                groups[city] = group;
                input = Console.ReadLine();
            }
            Dictionary<string, long> cityCapacity = new Dictionary<string, long>();
            foreach (var item in cityVehicle)
            {
                cityCapacity[item.Key] = SumCapacity(item.Value);
            }
            foreach (KeyValuePair<string,long> group in groups)
            {
                if (cityCapacity[group.Key] >=group.Value)
                {
                    Console.WriteLine($"{group.Key} -> all {group.Value} accommodated");
                }
                else
                {
                    Console.WriteLine($"{group.Key} -> all except {group.Value- cityCapacity[group.Key]} accommodated");
                }
            }
        }

        static long SumCapacity(Dictionary<string, long> n)
        {
            long sum = 0;
            foreach (var item in n)
            {
                sum += item.Value;
            }
            return sum;
        }
    }
}
