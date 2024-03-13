namespace dailypink.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string? ImageURL { get; set; }
        public string? Description { get; set; }
        public Category? Category { get; set; }

        // Below ones UI purposes only
        public string? CategoryName { get; set; }
        public int? CategoryId { get; set; }
    }
}
