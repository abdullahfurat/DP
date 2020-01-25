using DesingPatter.GenericRepositoryEF_3.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DesingPatter.GenericRepositoryEF_3.Contracts
{
    public interface IService<T>
        where T : CoreEntity, new()
    {
        void Add(T item);

        List<T> GetAll();

        bool Any(Expression<Func<T, bool>> exp);
    }
}
