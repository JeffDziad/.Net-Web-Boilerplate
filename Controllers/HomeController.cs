using Microsoft.AspNetCore.Mvc;

namespace ViewsTest.AddControllersWithViews
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}