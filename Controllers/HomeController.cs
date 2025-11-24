using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ReviewApp.Models;

namespace ReviewApp.Controllers;

public class HomeController : Controller
{
    private static IList<UserModel> userList = new List<UserModel>()
    {
        new UserModel ("isal0037@student.umu.se", "isal0037", "Isac Juselius"),
        new UserModel ("Omar.Lundgren@gmail.com", "omar", "Omar Lundgren")
    };

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult LoginSubmit(UserModel user)
    {

        var loginUser = userList.FirstOrDefault(u => u.Email.Equals(user.Email, StringComparison.OrdinalIgnoreCase)
         && u.Password == user.Password);

        if (loginUser != null)
        {

            HttpContext.Session.SetString("UserName", loginUser.Name);
            return RedirectToAction("Index", "Home");
        }
        else
        {
            ViewBag.Error = "Invalid email or password.";
            return View("Login", user);
        }
    }

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    
}
