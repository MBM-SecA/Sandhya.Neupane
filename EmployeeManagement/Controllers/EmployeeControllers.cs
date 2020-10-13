using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller
{
    public ActionResult Index()
    {

        // Object initializer syntax

        List<Person> employees = Person.GetEmployee();
        return View(employees);
    }

    public ActionResult Detail(string firstname)
    {
        List<Person> persons = Person.GetEmployee();
        Person p1 = null;
        foreach(var p in persons)
        {
            if (p.FirstName == firstname)
            {
                p1 =p;
            }
        }
        if (p1 != null)
        {
            return View(p1);
        }
        return View();
    }
}

