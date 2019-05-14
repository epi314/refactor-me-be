using System;
using System.Collections.Generic;

using RefactorMe.DontRefactor.Models;
using RefactorMe.Services;
using RefactorMe.Services.Implementations;

namespace RefactorMe
{
    public class ProductDataConsolidator
    {
        public static List<Product> Get() {
            IProductService repoService = new RepositoryService();
            return repoService.GetProducts();
        }

        public static List<Product> GetInUSDollars() {
            IProductService repoService = new RepositoryService();
            return repoService.GetProducts(0.76);
        }

        public static List<Product> GetInEuros() {
            IProductService repoService = new RepositoryService();
            return repoService.GetProducts(0.67);
        }
 
 
    }
}
