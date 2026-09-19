using Microsoft.AspNetCore.Mvc;

namespace BSIT31E2_Karunungan_Eirene_Portfolio.Controllers
{
    public class AccountController : Controller
    {
        private const string HardcodedUsername = "admin";
        private const string HardcodedPassword = "admin123!";

        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") == "true")
            {
                return RedirectToAction("Index", "Projects");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == HardcodedUsername && password == HardcodedPassword)
            {
                HttpContext.Session.SetString("IsLoggedIn", "true");
                HttpContext.Session.SetString("Username", username);
                return RedirectToAction("Index", "Projects");
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}