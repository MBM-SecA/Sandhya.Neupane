using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller
{
    public ActionResult Index()
    {


        // Object initializer syntax

        Person empl1 = new Person() { FirstName = "SAndhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl2 = new Person() { FirstName = "SAndhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl3 = new Person() { FirstName = "SAndhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl4 = new Person() { FirstName = "SAndhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl5 = new Person() { FirstName = "SAndhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };
        Person empl6 = new Person() { FirstName = "SAndhya", SureName = "Neupane", Address = "Patan Dhoka", Salary = 10111 };

        List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6 };
        return View(employees);
    }
}

