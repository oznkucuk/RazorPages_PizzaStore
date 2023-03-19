using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_PizzaStore.Model;

namespace RazorPages_PizzaStore.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public Pizza Pizza { get; set; }

        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;
            PizzaPrice += Pizza.Sauce ? 1 : 0;
            PizzaPrice += Pizza.Cheese ? 1 : 0;
            PizzaPrice += Pizza.Peperoni ? 1 : 0;
            PizzaPrice += Pizza.Mushroom ? 1 : 0;
            PizzaPrice += Pizza.Tuna ? 1 : 0;
            PizzaPrice += Pizza.Pineapple ? 1 : 0;
            PizzaPrice += Pizza.Ham ? 1 : 0;
            PizzaPrice += Pizza.Beef ? 1 : 0;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.Name, PizzaPrice });
        }
    }
}
