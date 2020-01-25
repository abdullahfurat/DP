using DesingPatter.GenericRepositoryEF_3.Models;
using System.Data.Entity;

namespace DesingPatter.GenericRepositoryEF_3.Dal
{
    public class ProjeContext : DbContext
    {
        public ProjeContext()
        {
            Database.Connection.ConnectionString = "";
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
