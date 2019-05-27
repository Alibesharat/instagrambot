using Microsoft.AspNetCore.Mvc;
using Spigram.Models;
using System.Diagnostics;

namespace Spigram.Controllers
{
    public class HomeController : Controller

    {
       
     
        public IActionResult Index()
        {

           

            return View();
        }
        private void start()
        {
            Debug.WriteLine("[Hi]========i=======");
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
