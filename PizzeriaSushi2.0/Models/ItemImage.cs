namespace PizzeriaSushi2._0.Models
{
    public class ItemImage
    {

        public int Id { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string? Name { get; set; }

        public string? ContentType { get; set; }

        public string? Base64Content { get; set; }

        public byte[]? BlobContent { get; set; }

        public int ItemId { get; set; }

        public Item? Item { get; set; }

    }
}
