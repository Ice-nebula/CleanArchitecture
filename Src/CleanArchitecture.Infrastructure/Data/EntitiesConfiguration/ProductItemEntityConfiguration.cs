using CleanArchitecture.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Data.EntitiesConfiguration
{
    internal class ProductItemEntityConfiguration : IEntityTypeConfiguration<ProductItem>
    {
        public void Configure(EntityTypeBuilder<ProductItem> builder)
        {
            builder.Property(x => x.ProductName)
                .HasMaxLength(250).IsRequired();
            builder.HasKey(x => x.Id);
        }
    }
}
