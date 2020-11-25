using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id { get; set; }

    [Required(ErrorMessage="*")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string Surname { get; set; }
    public string? Address { get; set; }
    public char? Gender { get; set; } = 'M';
    public double? Salary { get; set; }

    public static List<Person> GetEmployee()
    {
        Person empl1 = new Person() { Id= 1, FirstName = "Sandhya", Surname = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl2 = new Person() { Id= 2, FirstName = "Sabita", Surname = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl3 = new Person() { Id= 3, FirstName = "Sita", Surname = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl4 = new Person() { Id= 4, FirstName = "Ram", Surname = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl5 = new Person() { Id= 5, FirstName = "HAri", Surname = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl6 = new Person() { Id= 6, FirstName = "Gita", Surname = "Neupane", Address = "Patan Dhoka", Salary = 10111 };

        List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6 };
        return employees;
    }

}