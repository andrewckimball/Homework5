using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AndrewHomework5.Models;
using Microsoft.AspNetCore.Mvc;

namespace AndrewHomework5.Components
{
    //Class to link to the Views/Components/NavigationMenu/Default.cshtml file
    public class CartSummaryViewComponent : ViewComponent
    {
        //Helps create a simple view component class that passes on the Cart to the View method
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
