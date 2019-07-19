using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BricksStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product {Name="Kombajn kołowy", Price=780},
            new Product {Name="Wesołe miasteczko", Price=1200},
            new Product {Name="Taj Mahal", Price=1700}
        }.AsQueryable<Product>();
    }
}
