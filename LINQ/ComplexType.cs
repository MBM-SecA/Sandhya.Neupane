using System.Linq;

public class ComplexType
{
    public void LearnRestrictions()
    {

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
                                  where invade.Continent == "Asia" && invade.IndependenceDay == default
                                  select invade.Name;
        foreach (var invade in notinvadedCountries)
        {
            Console.WriteLine(invade);
        }
    }}


// HW - IS there any african country in your country collection.
// HW - Print first two largest asian countries names.

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
