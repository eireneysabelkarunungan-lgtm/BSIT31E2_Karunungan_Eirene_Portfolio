using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT31E2_Karunungan_Eirene_Portfolio.Models;

namespace BSIT31E2_Karunungan_Eirene_Portfolio.Controllers;

public class HomeController : Controller
{
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
