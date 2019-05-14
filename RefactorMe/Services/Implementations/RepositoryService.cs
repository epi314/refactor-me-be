using System;
using System.Collections.Generic;
using RefactorMe.DontRefactor.Models;

namespace RefactorMe.Services.Implementations
{
    public class RepositoryService : IProductService
    {

        private readonly IProductDatasource[] _datasources = {
            new LawnmowerDatasource(),
            new PhoneCaseDatasource(),
            new TShirtDatasource()
        };

        public RepositoryService()
        {
        }

        public List<Product> GetProducts(double rate = 1)
        {
            var products = new List<Product>();

            foreach (var source in _datasources)
            {
                products.AddRange(source.GetProducts(rate));
            }

            return products;
        }
    }
}
