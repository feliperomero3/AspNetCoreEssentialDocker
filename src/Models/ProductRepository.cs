using System.Collections.Generic;
using System.Linq;

namespace ExampleApp.Models;

public class ProductRepository
{
    private static readonly Product[] dummyData =
    [
        new() { ProductId = 1, Name = "Apple iPhone 14", Category = "Electronics", Price = 999 },
        new() { ProductId = 2, Name = "Samsung Galaxy S21", Category = "Electronics", Price = 799 },
        new() { ProductId = 3, Name = "Sony WH-1000XM4 Headphones", Category = "Electronics", Price = 349 },
        new() { ProductId = 4, Name = "Dell XPS 13 Laptop", Category = "Computers", Price = 1199 },
        new() { ProductId = 5, Name = "Apple MacBook Pro", Category = "Computers", Price = 1299 },
        new() { ProductId = 6, Name = "Nike Air Max 270", Category = "Footwear", Price = 150 },
        new() { ProductId = 7, Name = "Adidas Ultraboost", Category = "Footwear", Price = 180 },
        new() { ProductId = 8, Name = "Levi's 501 Original Jeans", Category = "Clothing", Price = 60 },
        new() { ProductId = 9, Name = "Ralph Lauren Polo Shirt", Category = "Clothing", Price = 85 },
        new() { ProductId = 10, Name = "The North Face Jacket", Category = "Clothing", Price = 199 },
        new() { ProductId = 11, Name = "KitchenAid Stand Mixer", Category = "Home Appliances", Price = 399 },
        new() { ProductId = 12, Name = "Dyson V11 Vacuum Cleaner", Category = "Home Appliances", Price = 599 },
        new() { ProductId = 13, Name = "Instant Pot Duo", Category = "Home Appliances", Price = 89 },
        new() { ProductId = 14, Name = "Sony PlayStation 5", Category = "Gaming", Price = 499 },
        new() { ProductId = 15, Name = "Microsoft Xbox Series X", Category = "Gaming", Price = 499 }
    ];

    public IList<Product> Products => dummyData.ToList();
}