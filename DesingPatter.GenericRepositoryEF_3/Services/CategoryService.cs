using DesingPatter.GenericRepositoryEF_3.Contracts;
using DesingPatter.GenericRepositoryEF_3.Models;

namespace DesingPatter.GenericRepositoryEF_3.Services
{
    public class CategoryService : CoreService<Category>, ICategoryService
    {

        // ICategoryService içerisinde var olan metot
        public Category CurrentCategory()
        {
            throw new System.NotImplementedException();
        }



        public override void Add(Category item)
        {

            if (Any(x => x.CategoryName == item.CategoryName))
            {
                throw new System.Exception("Aynı Kategori Eklenemez");
            }

            base.Add(item);
        }
    }
}
