using System;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ - LAnguage Integrated Query

            int[] numbers = { 23, 34, 45, 67, 87, 32, 22, 44 };

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
            // foreach (var name in result4)
            // {
            //     Console.WriteLine(name);
            // }

            // Projecctions
            var result5 = numbers.Select(x => x * x);
            foreach (var square in result5)
            {
                Console.WriteLine(square);
            }

            // Ordering
            var result6 = from num in result5
                          orderby num
                          select num;

            // Partitoning 
            var result7 = numbers.Skip(5).Take(5);

            // Quantifier
            var result8 = numbers.Any(x => x % 2 == 0);//Any returns bool vaule)
            var result9 = numbers.All(x => x % 2 == 0);
            var result10 = numbers.Contains(34);

            var result11 = Enumerable.Range(1, 1000);
            var result12 = Enumerable.Repeat("Hello World", 10);

            foreach (var num in result11)
            {
                Console.WriteLine(num);
            }

            ComplexType complexType = new ComplexType();
            complexType.LearnRestrictions();
        }
    }
}


// List countries in Europe which have population less than 100k
// list Asian Countries which are not ever invaded