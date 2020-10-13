using System.Collections.Generic;

public class Person
{
    public string FirstName { get; set; }
    public string SureName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Person> GetEmployee()
    {
        Person empl1 = new Person() { FirstName = "Sandhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl2 = new Person() { FirstName = "Sandhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl3 = new Person() { FirstName = "Sandhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl4 = new Person() { FirstName = "Sandhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl5 = new Person() { FirstName = "Sandhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl6 = new Person() { FirstName = "Sandhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };

        List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6 };
        return employees;
    }

}