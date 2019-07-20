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
            new Product {Name="Kombajn kołowy", Category="Technic", Price=780, Description="Krótki opis..."},
            new Product {Name="Wesołe miasteczko", Category="Creator", Price=1200},
            new Product {Name="Taj Mahal", Category="Creator Expert", Price=1700}
        }.AsQueryable<Product>();
    }
}
