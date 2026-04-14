using Microsoft.AspNetCore.Mvc;

namespace PedritoMVC.Controllers;

public class UserController : Controller
{
    //retornamos vista,json,xml SOAP, entre otros
    public IActionResult Index()
    {
        return View();
    }
}