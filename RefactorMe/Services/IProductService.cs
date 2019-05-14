using System;
using System.Collections.Generic;

using RefactorMe.DontRefactor.Models;

namespace RefactorMe.Services
{
    public interface IProductService
    {
        List<Product> GetProducts(double rate = 1);
    }
}
