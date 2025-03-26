using System.Collections.Generic;
using System.Linq;

namespace ExampleApp.Models;

public class ProductRepository
{
    private static readonly Product[] dummyData = new[] {
        new Product { Name = "Product 1", Category = "Category 1", Price = 100 },
        new Product { Name = "Product 2", Category = "Category 1", Price = 200 },
        new Product { Name = "Product 3", Category = "Category 2", Price = 500 },
        new Product { Name = "Product 4", Category = "Category 2", Price = 600 },
    };

    public IList<Product> Products => dummyData.ToList();
}