using EmployeeSystem.Data.DataAccess.Interfaces;
using EmployeeSystem.Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EmployeeSystem.Data.DataAccess.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private  EmployeeMSContext context;
        public BaseRepository(EmployeeMSContext _context)
        {
            context = _context;
        }

        public EmployeeMSContext Context { get {
                return context;
            } set {
                context = value;
            } }

        public virtual void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }

       
        public virtual void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Edit(T entity, string User)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = Context.Set<T>().Where(predicate);
            return query;
        }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = Context.Set<T>();
            return query;
        }

        public void Save()
        {
            Context.SaveChanges();
        }
        public int GetNumberOf(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).Count();

        }
    }
}
