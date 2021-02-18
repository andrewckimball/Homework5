using AndrewHomework5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AndrewHomework5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookstoreRespository _repository;

        public HomeController(ILogger<HomeController> logger, IBookstoreRespository respository)
        {
            _logger = logger;
            _repository = respository;
        }

        public IActionResult Index()
        {
            //Returning the view to display the index.cshtml page
            return View(_repository.Projects);
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
