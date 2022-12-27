using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AdditionWebsite.Controllers
{
    public class AddController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddDisplay(int a,int b)
        {
            int ans = a + b;
            ViewBag.Ans1 = ans;

            return View();
        }
    }
}
