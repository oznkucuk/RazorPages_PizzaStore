using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_PizzaStore.Data;
using RazorPages_PizzaStore.Model;

namespace RazorPages_PizzaStore.Pages.Admin
{
    public class OrdersListModel : PageModel
    {
        private readonly PizzaDbContext _context;

        public OrdersListModel(PizzaDbContext context)
        {
            _context = context;
        }

        public IList<PizzaOrder> PizzaOrder { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PizzaOrders != null)
            {
                PizzaOrder = await _context.PizzaOrders.ToListAsync();
            }
        }
    }
}
