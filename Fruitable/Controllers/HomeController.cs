using System.Diagnostics;
//using Fruitable.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fruitable.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
