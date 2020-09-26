using System;
using System.Collections.Generic;

public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public double Area { get; set; }
    public long Population { get; set; }
    public DateTime IndependenceDay { get; set; }

    public Country(string n, string c, double a, long p, DateTime i = default)
    {
        Name = n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
    }
    
    public static List<Country> GetCountries()
    {
        Country c1 = new Country("Nepal", "Asia", 25684, 6382988);
        Country c2 = new Country("India", "Asia", 2584, 638298893, new DateTime(1947, 08, 15));
        Country c3 = new Country("Russia", "Europe", 2563213, 88693);
        Country c4 = new Country("USA", "North America", 223484, 638893);
        Country c5 = new Country("China", "Asia", 4854, 638893, new DateTime(1900, 01, 15));
        Country c6 = new Country("Japan", "Asia", 284, 638323);
        Country c7 = new Country("Kenya", "Africa", 63845.23, 638298);
        Country c8 = new Country("Argentina", "South America", 535.543, 612323);
        Country c9 = new Country("Brazil", "South America", 253, 32763);
        Country c10 = new Country("Canada", "North America", 254384, 32374423);
        Country c11 = new Country("Spain", "Europe", 2532, 27724);
        Country c12 = new Country("Germany", "Europe", 25334, 6382434);
        Country c13 = new Country("Italy", "Europe", 2111, 63893);
        Country c14 = new Country("Bhutan", "Asia", 243244, 638423);
        Country c15 = new Country("France", "Europe", 23184, 3623321);
        Country c16 = new Country("Uganda", "Africa", 232.43, 3232);
        Country c17 = new Country("UK", "Europe", 2532, 72367263);
        Country c18 = new Country("Pakistan", "Asia", 2511, 45345);
        Country c19 = new Country("Srilanka", "Asia", 2522, 656564);
        Country c20 = new Country("Korea", "Asia", 256384, 32323, new DateTime(1917, 01, 5));
        Country c21 = new Country("Kenya", "Africa", 25638324, 32233);
        Country c22 = new Country("UAE", "Asia", 2563234, 3223244, new DateTime(1847, 08, 5));
        Country c23 = new Country("Portugal", "Europe", 284, 63823);
        
        

        List<Country> countries = new List<Country> { c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23 };

        return countries;

    }
}