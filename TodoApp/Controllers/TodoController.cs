using Microsoft.AspNetCore.Mvc;

namespace TodoApp.Controllers;

public class TodoController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}