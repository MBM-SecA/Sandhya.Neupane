using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - LAnguage Integrated Query

            int[] numbers = { 23, 34, 45, 67, 87, 32, 22 };

            // Fetch numbers which are greater than 50 and less than 70.

            //Using Methhod syntax - Lambda expression
            var result1 = numbers.Where(x => x > 50 && x < 70);

            //Using sql querry syntax - Querry expression
            var result2 = from x in numbers
                          where x > 50 && x < 70
                          select x;


            string[] names = { "sandhya", "abc", "ram", "ramesh", "rajesh", "Ronaldo" };

            // Name having length > 3 and statrs with r.
            var result3 = names.Where(y => y.Length > 3 && y.StartsWith("r"));

            var result4 = from y in names
                          where y.Length > 3 && y.ToLower().StartsWith("r")
                          select y;
            foreach (var y in result4)
            {
                Console.WriteLine(y);
            }

            var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country.Name;
            // foreach (var country in asianCountries)
            // {
            //     Console.WriteLine(country);
            // }

            var europeanCountries = from population in countries
                                    where population.Population < 100000 && population.Continent == "Europe"
                                    select population.Name;
            foreach (var population in europeanCountries)
            {
                Console.WriteLine(population);
            }

            var notinvadedCountries = from invade in countries
                                      where invade.Name = "Asia" && invade.IndependenceDay = "default"
                                      select invade.Name;
            foreach (var invade in notinvadedCountries)
            {
                Console.WriteLine(invade);
            }


            // List<Country> countries = new List<Country>();

            // Country c1 = new Country();
            // c1.Name = "Nepal";
            // c1.Continent = "Asia";
            // c1.Area = 53637.432;
            // c1.Population= 4677648328;


            // Country c1 = new Country()
            // {
            //     Name = "Nepal",
            //     Continent = "Asia",
            //     Area = 53637.432,
            //     Population= 4677648328
            // };

            // countries.Add(c1);

        }
    }
}


// List countries in Europe which have population less than 100k
// list Asian Countries which are not ever invaded