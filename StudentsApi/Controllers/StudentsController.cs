using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using StudentsApi.Models;
using Microsoft.EntityFrameworkCore;
using StudentsApi.Data;
using System.Linq;
using System;

[Route("students")]
[ApiController]
public class StudentController:ControllerBase
{
    private StudentsContext db;
    public StudentController(StudentsContext _db) => db = _db;

    [HttpGet]
    [Route("all")]
   public ActionResult GetAllStudents()

   {
       var students = db.Student.ToList();

    if (students== null)
    {
        return NotFound();
    }
           return Ok(students);
   }

   [HttpGet]
   [Route("id")]
   public ActionResult GetStudentById(string Id)
   {
   var student = db.Student.Find(Id);
        
    if (student==null)
        return NotFound("Student not found");
    
    return Ok(student);
   }

   [HttpPost]
   [Route("add")]
    public ActionResult CreateStudent(Student student)
   {
       if(student==null)
       return BadRequest();
       db.Student.Add(student);
       db.SaveChanges();
       
       return Created("",student);

   }
   [HttpPut]
   [Route("update")]
    public ActionResult UpdateStudent(Student student)
   {
       if(student==null)
       return BadRequest();
        db.Student.Attach(student);
        db.Student.Update(student);
       db.SaveChanges();

     return Created("Updated student",student);

   }

   [HttpDelete]
   [Route("delete")]
    public ActionResult RemoveStudent(Student student)
   {
       if(student==null)
       return BadRequest();

        db.Student.Attach(student);
        db.Student.Remove(student);
        db.SaveChanges();
        var result=$"Removed {student.Name} with id ={student.Id}";
        return Ok(result);

   }

   }
