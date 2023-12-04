using PizzeriaSushi2._0.Enums;

namespace PizzeriaSushi2._0.Models
{
    public class Item
    {

        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public int? OrderCount { get; set; }

        public FoodCategory FoodCategory { get; set; }

        public int RestaurantId { get; set; }

        public Restaurant? Restaurant { get; set; }

    }
}
