using _10PAGESFKINGSHIT.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace _10PAGESFKINGSHIT.Controllers
{
    public class MainController : Controller
    {
        public IActionResult loadLogin()
        {
            return View("~/Views/Main/login.cshtml");
        }
        
        public IActionResult login(login mod)
        {
            Random random = new Random();
            if (mod.username == "admin" && mod.password == "123")
            {
                ViewBag.Tries = 0;
                return View("~/Views/Main/mainDashboard.cshtml");
            }
            else
            {
                double chance = 0.01;
                double randnum = random.NextDouble();
                if (randnum <= chance)
                {
                    ViewBag.Message = "try 'admin' and '123' \n sbapn";
                }
                else
                {
                    ViewBag.Message = "Wrong username and password" + randnum;
                }
                return View("~/Views/Main/login.cshtml");
            }
        }
    }
}
