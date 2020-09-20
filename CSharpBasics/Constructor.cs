namespace AllAboutClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public readonly double AREA = 3456.56;
        public static readonly bool IsOnEarth;


        // Instance Constructors
        // Default constructor
        public Country()
        {

        }

        // Parameterized constructor
        public Country(string name)
        {
            Name = name;
        }

        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;
        }

        // Static Constructor (used only one time i.e. singleton pattern)
        static Country()
        {
            IsOnEarth = true;
        }

        // Finalizer or Destructor
        // ~Country()
        // {
        //     Console.WriteLine("I am dying.");
        // }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");
        }
    }

}