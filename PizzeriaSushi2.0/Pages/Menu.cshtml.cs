using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PizzeriaSushi2._0.Database;
using PizzeriaSushi2._0.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzeriaSushi2._0.Pages
{
    public class MenuModel : PageModel
    {
        private readonly ILogger<MenuModel> _logger;
        private readonly PizzeriaSushi2._0.Database.Database _context;

        public MenuModel(ILogger<MenuModel> logger, PizzeriaSushi2._0.Database.Database context)
        {
            _logger = logger;
            _context = context;
        }

        public List<Item> MenuItems { get; set; }

        public async Task OnGetAsync()
        {
            MenuItems = await _context.Items.ToListAsync();
        }
    }
}