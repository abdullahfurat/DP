using DesingPatter.GenericRepositoryEF_3.Contracts;
using DesingPatter.GenericRepositoryEF_3.Models;
using DesingPatter.GenericRepositoryEF_3.Services;

namespace DesingPatter.GenericRepositoryEF_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService _productService = new ProductService();
            _productService.Add(new Product());

            CategoryService _categoryService = new CategoryService();


            _categoryService.Add(new Category() { CategoryName = "Beverages" });




        }
    }
}
