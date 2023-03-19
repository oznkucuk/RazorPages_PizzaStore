using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages_PizzaStore.Model;

namespace RazorPages_PizzaStore.Pages
{
    public class PizzaSaleModel : PageModel
    {
        public List<Pizza> FakePizzaDB = new List<Pizza>()
        {
            new Pizza {
                ImageTitle="Margerita",
                Name="Margerita",
                BasePrice=2,
                Sauce=true,
            Cheese=true,
            FinalPrice=4
            },
            new Pizza {
                ImageTitle = "Bolognese",
                Name = "Bolognese",
                BasePrice = 2,
                Sauce = true,
                Cheese = true,
                Beef = true,
                FinalPrice = 5
            },
            new Pizza {
                ImageTitle="Carbonara",
                Name="Carbonara",
                BasePrice=2,
                Sauce=true,
                Cheese=true,
                Ham=true,
                FinalPrice=5
            },
            new Pizza {
                ImageTitle="Hawaiian",
                Name="Hawaiian",
                BasePrice=2,
                Sauce=true,
                Cheese=true,
                Peperoni=true,
                Pineapple=true,
                FinalPrice=6
            },
            new Pizza {
                ImageTitle="MeatFeast",
                Name="MeatFeast",
                BasePrice=2,
                Sauce=true,
                Cheese=true,
                FinalPrice=4
            },
            new Pizza {
                ImageTitle="Mushroom",
                Name="Mushroom",
                BasePrice=2,
                Sauce=true,
                Cheese=true,
                FinalPrice=4
            },
            new Pizza {
                ImageTitle="Pepperoni",
                Name="Pepperoni",
                BasePrice=2,
                Sauce=true,
                Cheese=true,
                FinalPrice=4
            },
            new Pizza {
                ImageTitle="Seafood",
                Name="Seafood",
                BasePrice=2,
                Sauce=true,
                Cheese=true,
                FinalPrice=4
            },
            new Pizza {
                ImageTitle="Vegetarian",
                Name="Vegetarian",
                BasePrice=2,
                Sauce=true,
                Cheese=true,
                FinalPrice=4
            }
        };
        public void OnGet()
        {
        }
    }
}
