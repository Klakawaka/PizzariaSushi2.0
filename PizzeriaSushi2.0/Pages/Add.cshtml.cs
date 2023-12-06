// PizzeriaSushi2.0/Pages/Add.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PizzeriaSushi2._0.Database;
using PizzeriaSushi2._0.Enums;
using PizzeriaSushi2._0.Models;

namespace PizzeriaSushi2._0.Pages
{
    public class AddModel : PageModel
    {
        private readonly ILogger<AddModel> _logger;
        private readonly Database.Database _dbContext; // Update the namespace here

        public AddModel(ILogger<AddModel> logger, Database.Database dbContext) // Update the namespace here
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        [BindProperty]
        public string ItemName { get; set; }

        [BindProperty]
        public string ItemDescription { get; set; }

        [BindProperty]
        public decimal? ItemPrice { get; set; }

        [BindProperty]
        public int? ItemOrderCount { get; set; }

        [BindProperty]
        public FoodCategory ItemFoodCategory { get; set; }

        public void OnGet()
        {
            // Load existing items or other data if needed
        }

        public IActionResult OnPost()
        {
            // Code to run when the form is submitted
            string itemName = ItemName;
            string itemDescription = ItemDescription;
            decimal? itemPrice = ItemPrice ?? 0; // Set a default value if null
            int? itemOrderCount = ItemOrderCount ?? 0; // Set a default value if null
            FoodCategory itemFoodCategory = ItemFoodCategory;

            // Create a new item
            var newItem = new Item
            {
                Name = itemName,
                Description = itemDescription,
                Price = itemPrice.Value,
                OrderCount = itemOrderCount.Value,
                FoodCategory = itemFoodCategory,
                RestaurantId = 1 // Replace with the actual RestaurantId
            };

            // Save the new item to the database
            _dbContext.Items.Add(newItem);
            _dbContext.SaveChanges();

            // Reload the page or redirect to another page
            return RedirectToPage("Index"); // Redirect to Index page as an example
        }
    }
}
