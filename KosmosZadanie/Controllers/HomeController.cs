using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KosmosZadanie.Models;
using KosmosZadanie.Data;

namespace KosmosZadanie.Controllers
{
    public class HomeController : Controller
    {
        private Repository _repostiory { get; }

        public HomeController(Repository repository) {
            _repostiory = repository;
        }
        public IActionResult Index()
        {
            var data = _repostiory.Wszechswiat;
            return View(data);
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
