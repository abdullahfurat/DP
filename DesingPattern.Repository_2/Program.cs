namespace DesingPattern.Repository_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ICategoryService _categoryService = new CategorService();

            IService<Category> _categoryService = new CategoryService(); 
            Category category = new Category();
            category.CategoryName = "Kategori Adı";

            _categoryService.Add(category);
        }
    }


    public class CoreEntity
    {
        public int Id { get; set; }
        public string CreatedComputerName { get; set; }
        public string CreatedIp { get; set; }
        public int CreatedBy { get; set; }
    }

    // Database ile haberşelecek olan modellerim :)
    public class Category : CoreEntity
    { 
        public string CategoryName { get; set; }
    }
    public class Product : CoreEntity { }

    //  form üzerinde kullanılacak olan yardımcı metotları barındırır.
    public class HelperMethods
    {
        public void Temizle()
        {
            // form üzerinde yer alan kontrolleri temizle
        }
    }

    public interface IService<T>
        where T : CoreEntity, new()
    {
        void Add(T item);
    }
     
    public class CategoryService : IService<Category>
    {
        public void Add(Category item)
        {
            throw new System.NotImplementedException();
        }
    }

    public class ProductService : IService<Product>
    {
        public void Add(Product item)
        {
            throw new System.NotImplementedException();
        }
    }
     






























    // https://medium.com/android-t%C3%BCrkiye/solid-prensipleri-5d2ef01f4eeb

     

    // Generic Repository Desing Pattern


    #region Generic
    //public interface IService<T> where T : class
    //{
    //    void Add(T item);
    //}

    //public class CategoryService : IService<Category>
    //{
    //    public void Add(Category item)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
    //public class ProductService : IService<Product>
    //{
    //    public void Add(Product item)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //} 
    #endregion

    // Repository Desing Pattern

    #region Örnek 2
    //public interface ICategoryService
    //{
    //    void Add(Category category); 
    //}

    //public class CategorService : ICategoryService
    //{
    //    public void Add(Category category)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //} 

    //public interface IProductService
    //{
    //    void Add(Product product);
    //}




    //public class ProductService : IProductService
    //{
    //    public void Add(Product product)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //} 
    #endregion

    #region Örnek
    //public class Category { }
    //public class Product { }

    //public interface IService
    //{
    //    void Add(Category category);
    //}

    //public class CategoryAdoService : IService // şebeke elektiriği
    //{
    //    public void Add(Category category)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
    //public class CategoryEFService : IService // jenerator
    //{
    //    public void Add(Category category)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}

    //public class CategorService : IService
    //{
    //    public void Add(Category category)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //}
    //public class ProductService : IService
    //{
    //    public void Add(Category category)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    //} 
    #endregion






















}
