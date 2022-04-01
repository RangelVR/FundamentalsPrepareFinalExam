using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{
    class City
    {
        public City(int population, int gold)
        {
            this.Population = population;
            this.Gold = gold;
        }

        public int Population { get; set; }

        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, City> cities = new Dictionary<string, City>();
           
            string input;
            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] citiesArgs = input
                    .Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string town = citiesArgs[0];
                int population = int.Parse(citiesArgs[1]);
                int gold = int.Parse(citiesArgs[2]);

                if (!cities.ContainsKey(town))
                {
                    cities.Add(town, new City(population, gold));
                    
                }
                else
                {
                    cities[town].Population += population;
                    cities[town].Gold += gold;
                }
               
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArr = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string @event = commandArr[0];
                string town = commandArr[1];
                

                if (@event == "Plunder")
                {
                    int people = int.Parse(commandArr[2]);
                    int gold = int.Parse(commandArr[3]);

                    cities[town].Population -= people;
                    cities[town].Gold -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                }
                

                if (@event == "Prosper")
                {
                    int gold = int.Parse(commandArr[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    cities[town].Gold += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury." +
                        $" {town} now has {cities[town].Gold} gold.");
                }

                if (cities[town].Population <= 0 || cities[town].Gold <= 0)
                {
                    cities.Remove(town);
                    Console.WriteLine($"{town} has been wiped off the map!");
                }

            }


            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens," +
                        $" Gold: {city.Value.Gold} kg");
                }
            }
        }
    }

    
}
