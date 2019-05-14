using System;
using System.Collections.Generic;

using RefactorMe.DontRefactor.Models;
using RefactorMe.DontRefactor.Data.Implementation;

namespace RefactorMe.Services.Implementations
{
    public class TShirtDatasource : TShirtRepository, IProductDatasource
    {
        public List<Product> GetProducts(double rate = 1)
        {
            var ps = new List<Product>();

            var products = GetAll();
            foreach (var product in products)
            {
                ps.Add(new Product()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price * rate,
                    Type = "T-Shirt"
                });
            }

            return ps;
        }
    }
}
