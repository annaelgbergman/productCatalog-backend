using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace WebApi_productCatalog.Models
{
    public class Product
    {
        public string ArticleNumber { get; set; } = null!;
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;
    }
}
