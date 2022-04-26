using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities.Products
{
    public class ProductItem: BaseEntity
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}
