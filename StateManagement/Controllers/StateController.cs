using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateController : Controller
{
    public ViewResult First()
    {
        // Statemanagement 
        //1.Client Side
        
        //1.1 Cookies
        var name = "Sandhya";
        Response.Cookies.Append("user", name);

        //1.2 Query String (Query Paramenters)
        HttpContext.Session.SetString("Address" , "ktm");

        return View();
    }

    [HttpGet]
    public ViewResult Second(string name, int age)
    {
        var userAddress = HttpContext.Session.GetString("Address");

        // 2.2 Temp data
        TempData["CollegeName"]= "MBM";
        return View();
    }

    [HttpPost]
    public bool Second(string collegeName)
    {
        return true;
    }

    public ViewResult Third()
    {
        // 2.2 Temp data
        var cName = TempData["CollegeName"];
        byte value = 67;
        ViewData["Name"] = "abc from viewdata";
        ViewBag.Name = "Hello";
        return View(value);
    }
}