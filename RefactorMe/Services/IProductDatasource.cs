using System;
using System.Collections.Generic;

using RefactorMe.DontRefactor.Models;


namespace RefactorMe.Services
{
    public interface IProductDatasource
    {
        List<Product> GetProducts(double rate = 1);
    }
}
