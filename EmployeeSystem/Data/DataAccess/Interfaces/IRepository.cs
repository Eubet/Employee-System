using EmployeeSystem.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Interfaces
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        
        void Delete(T entity);
        void Edit(T id);

        void Save();
    }
}
