using DesingPatter.GenericRepositoryEF_3.Models;
using System.Collections.Generic;

namespace DesingPatter.GenericRepositoryEF_3.Contracts
{
    public interface IService : IService<Product>
    {
        List<Product> SaleProducts();
    }
}
