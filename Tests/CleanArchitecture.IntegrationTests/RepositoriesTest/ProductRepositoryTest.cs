using CleanArchitecture.Domain.Entities.Products;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.Infrastructure.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.IntegrationTests.RepositoriesTest
{
    public class ProductRepositoryTest
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbConnection _connection;
        private readonly DbContextOptions<DataContext> _dbContextOptions;
        public ProductRepositoryTest()
        {
            _connection = new SqliteConnection("Filename=:memory:");
            _connection.Open();
            _dbContextOptions = new DbContextOptionsBuilder<DataContext>().UseSqlite(_connection).Options;
            using var dataContext = new DataContext(_dbContextOptions);
            if (dataContext.Database.EnsureCreated())
            {
                dataContext.Database.Migrate();
                _unitOfWork = new UnitOfWork(dataContext);
            } //end if
        } //end constructor
        [Fact]
        public async void CreateNewProductTest()
        {
            //arrange
            var entity = new ProductItem();
            entity.ProductName = "df";
            entity.ProductDescription = "dexcription";
           //act
            _unitOfWork.Product.AddNewAsync(entity);
            await _unitOfWork.SaveAsync();
            var query = await _unitOfWork.Product.Where(x => x.ProductName == entity.ProductName).FirstOrDefaultAsync();
            //assert
            Assert.Equal(1, _unitOfWork.Product.GetAll().Count());
            Assert.Equal(entity.ProductName, query.ProductName);
            Assert.Equal(entity.ProductDescription, query.ProductDescription);
        }
    }
}
