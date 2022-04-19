using CleanArchitecture.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Interfaces.Repositories
{
    public interface IProductRepository: IRepositoryBase<ProductItem>
    {
    }
}
