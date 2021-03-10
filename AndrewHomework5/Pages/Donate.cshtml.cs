using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AndrewHomework5.Models;
using AndrewHomework5.Infrastructure;

namespace AndrewHomework5.Pages
{
    //Model relating to the Donate.cshtml page
    public class DonateModel : PageModel
    {
        private IBookstoreRespository repository;

        //Constructor passing in variables
        public DonateModel(IBookstoreRespository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        //New handler method in the page model class that will receive the request and modify the cart
        //Method to add items to cart
        public IActionResult OnPost(long projectId, string returnUrl)
        {
            Project project = repository.Projects.FirstOrDefault(p => p.ProjectId == projectId);
            //Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(project, 1);

            //HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        //Method to remove items from cart
        public IActionResult OnPostRemove(long proj, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Project.ProjectId == proj).Project);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
