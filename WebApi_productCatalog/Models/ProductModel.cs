namespace WebApi_productCatalog.Models
{
    public class ProductModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public int ArticelNumber { get; set; } 
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;

        public string PartionKey => Id;

    }
}
