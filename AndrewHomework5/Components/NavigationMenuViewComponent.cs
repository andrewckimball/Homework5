using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndrewHomework5.Models;

namespace AndrewHomework5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookstoreRespository repository;
        public NavigationMenuViewComponent(IBookstoreRespository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Projects
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
