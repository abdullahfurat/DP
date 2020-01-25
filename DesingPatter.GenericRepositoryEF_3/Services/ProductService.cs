using DesingPatter.GenericRepositoryEF_3.Contracts;
using DesingPatter.GenericRepositoryEF_3.Models;
using System;
using System.Collections.Generic;

namespace DesingPatter.GenericRepositoryEF_3.Services
{
    public class ProductService : CoreService<Product>, IService
    {
        public List<Product> SaleProducts()
        {
            throw new NotImplementedException();
        }
    }
}
