using DesingPatter.GenericRepositoryEF_3.Models;

namespace DesingPatter.GenericRepositoryEF_3.Contracts
{
    public interface ICategoryService : IService<Category>
    {
        Category CurrentCategory();
    }
}
