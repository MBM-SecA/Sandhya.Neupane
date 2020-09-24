using LearnCollections;
using System.IO;
using System.Linq;
using System;

public class Program
{
    static void Main()
    {
        var countriesText = File.ReadAllText("Countries.txt");
        string[] countries = countriesText.Split("\r\n");

        var countriesWithNInitial = countries.Where(x => x.StartsWith("N")).Select(x => x);

        foreach (var country in countriesWithNInitial)
        {
            Console.WriteLine(country);
        }
    }
}
// FileIO fileIO = new FileIO();
// fileIO.LearnDirectories();

//     // Collections collections = new Collections();
//     // collections.LearnDictionary();

//    Square square = new Square(12.4);
//     //square.Side = 12;
//     square.Display();
//    //var SquareArea = square.GetArea();

//     var rect = new Rectangle(12.4 , 16.1);
//     var AreaRect =  rect.GetArea();
//     var CircRect = rect.GetCircumference();

