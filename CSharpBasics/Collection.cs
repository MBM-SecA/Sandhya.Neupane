using System;
using System.Collections.Generic;

namespace LearnCollections
{
    public class Collections
    {
        void LearnLists()
        {
            List<byte> ages = new List<byte>{ 2, 3 };

            ages.Add(1);
            ages.Add(10);
            ages.Add(100);
            ages.Add(255);

            List<Country> countries = new List<Country>();
            Country country1 = new Country();
            countries.Add(country1);
        }

        public void LearnDictionary()
        {
            var countryCapitals = new Dictionary<string, string>
            {
                ["Nepal"] = "Kathmandu",
                ["India"] = "New Delhi",
                ["Japan"] = "Tokyo" 
            };

            foreach (var country in countryCapitals)
            {
                Console.WriteLine($"Country: {country.Key} Capital City: {country.Value}");
            }

            // Dictionary<string, string> countryCapitals = new Dictionary<string, string>();
            // countryCapitals.Add("Nepal", "Kathmandu");
            // countryCapitals.Add("India", "New Delhi"); 
            // countryCapitals.Add("Japan", "Tokyo");  


        }
    }

    public class Country
    {
        public string Name { get; set; }
    }
}