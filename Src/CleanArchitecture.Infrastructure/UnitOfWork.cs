using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Interfaces.Repositories;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        private IProductRepository _product;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }//end constructor

        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_dataContext);
                } //end if
                return _product;
            } //end get
        } //end product 

         public async Task SaveAsync()
        {
            await _dataContext.SaveChangesAsync();
        }
    }
}
