using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndrewHomework5.Models;

namespace AndrewHomework5.Components
{
    //Class to link to the Views/Components/CartSummary/Default.cshtml file
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
