using System;
using System.Linq;
using System.Collections.Generic;
using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController: Controller
{
    private EMSContext db;

    public EmployeeController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        // var db = new EMSContext();
        var employees = db.People.ToList();

        return View(employees);
    }

    public ActionResult Detail([FromQuery]int id)
    {

        // var employees = Person.GetEmployee();
        // Person employee = employees.FirstOrDefault(x => x.Id == id);

        var employee = db.People.Find(id);
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

    [HttpGet]
    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<string> Add(Person person)
    {
        db.People.Add(person);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Edit(Person person)
    {
        db.People.Attach(person);
        db.People.Update(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        var employee = db.People.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Delete(Person person)
    {
        db.People.Attach(person);
        db.People.Remove(person);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}

