using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_PizzaStore.Data;
using RazorPages_PizzaStore.Model;

namespace RazorPages_PizzaStore.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string Name { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly PizzaDbContext _context;

        public CheckoutModel(PizzaDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
                Name = "Custom";

            if (string.IsNullOrWhiteSpace(ImageTitle))
                ImageTitle = "Create";

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.Name = Name;
            pizzaOrder.Price = PizzaPrice;
            pizzaOrder.Date = DateTime.Now;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
        }
    }

}
