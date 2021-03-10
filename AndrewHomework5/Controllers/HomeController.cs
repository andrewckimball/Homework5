using AndrewHomework5.Models;
using AndrewHomework5.Models.ViewModel;
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

        //Displaying 5 items per page
        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookstoreRespository respository)
        {
            _logger = logger;
            _repository = respository;
        }

        //Default to page 1, organize by 5 books each page
        public IActionResult Index(string category, int pageNum = 1)
        {
            return View(new ProjectListViewModel
            {
                Projects = _repository.Projects
                                    .Where(p => category == null || p.Category == category)
                                    .OrderBy(p => p.ProjectId)
                                    .Skip((pageNum - 1) * PageSize)
                                    .Take(PageSize)
                                ,
                PagingInfo = new PageInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    //TotalNumItems = _repository.Projects.Count()
                    //If category is null, total pages is normal, if category is specified, count how many of the category exist
                    TotalNumItems = category == null ? _repository.Projects.Count() :
                        _repository.Projects.Where(x => x.Category == category).Count()
                },
                CurrentCategory = category
            });
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
