using DesingPatter.GenericRepositoryEF_3.Contracts;
using DesingPatter.GenericRepositoryEF_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DesingPatter.GenericRepositoryEF_3.Services
{
    public class CoreService<T> : IService<T> where T : CoreEntity, new()
    {
        Dal.ProjeContext db = new Dal.ProjeContext();
        public virtual void Add(T item)
        {
            db.Set<T>().Add(item);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }
    }
}
