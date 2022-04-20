using CleanArchitecture.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContext _dataContext { get; set; }

        protected RepositoryBase(DataContext dataContext)
        {
            _dataContext = dataContext;
        } //end constructor

        public IQueryable<T> GetAll()
        {
            return _dataContext.Set<T>().AsNoTracking();
        } //end method

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dataContext.Set<T>().Where(expression);
        }

        public async Task AddNewAsync(T Entity)
        {
            await _dataContext.Set<T>().AddAsync(Entity);
        } //end method
    } //end class
}
