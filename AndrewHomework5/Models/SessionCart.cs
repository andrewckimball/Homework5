using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using AndrewHomework5.Infrastructure;
using System.Threading.Tasks;

namespace AndrewHomework5.Models
{
    //Subclass of the cart model, overriding the AddItem, RemoveLine, and Clear methods so they call the base implementations
    public class SessionCart : Cart
    {
        //Factory for creating SessionCart objects and providing them with an ISession object
        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart")
                ?? new SessionCart();
            cart.Session = session;
            return cart;
        }

        [JsonIgnore]
        public ISession Session { get; set; }
        public override void AddItem(Project proj, int quantity)
        {
            base.AddItem(proj, quantity);
            Session.SetJson("Cart", this);
        }
        public override void RemoveLine(Project proj)
        {
            base.RemoveLine(proj);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.Remove("Cart");
        }
    }
}
