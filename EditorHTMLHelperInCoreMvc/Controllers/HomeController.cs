using EditorHTMLHelperInCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EditorHTMLHelperInCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                EmployeeId=101,
                Name="Mukesh Kumar",
                Gender=Gender.Male,
                Age=34,
                IsNewlyAdded=true,
                DOB=Convert.ToDateTime("10-06-1989")

            };
            return View(emp);
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
}