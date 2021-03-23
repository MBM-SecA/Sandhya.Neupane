using System;
using System.Linq;
using System.Collections.Generic;
using EmployeeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

public class DepartmentController: Controller
{
    private EMSContext db;

    public DepartmentController(EMSContext _db)
    {
        db = _db;
    }
    public ActionResult Index()
    {
        // var db = new EMSContext();
        var departments = db.Departments.ToList();
        return View(departments);
    }

    public ActionResult Detail([FromQuery]int id)
    {  
       var  Department = db.Departments.Find(id);
       return View(Department);
    }

    public ActionResult Add()
    {
        return View();
    }
    
    [HttpPost]
    public ActionResult<string> Add(Department department)
    {
        db.Departments.Add(department);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

}

