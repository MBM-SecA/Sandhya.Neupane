using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller
{
    public ActionResult Index()
    {
        List<Person> employees = Person.GetEmployee();
        return View(employees);
    }

    public ActionResult Detail([FromQuery]int id)
    {

        var employees = Person.GetEmployee();
        Person employee = employees.FirstOrDefault(x => x.Id == id);

        return View(employee);

        // List<Person> persons = Person.GetEmployee();
        // Person p1 = null;
        // foreach(var p in persons)
        // {
        //     if (p.FirstName == firstname)
        //     {
        //         p1 =p;
        //     }
        // }
        // if (p1 != null)
        // {
        //     return View(p1);
        // }
        // return View();
    }

    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<string> Add(Person person)
    {
        return "Record Saved";
    }
}

