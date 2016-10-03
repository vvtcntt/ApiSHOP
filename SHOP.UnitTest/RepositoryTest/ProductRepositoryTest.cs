using Microsoft.VisualStudio.TestTools.UnitTesting;
using SHOP.Data.Infratructure;
using SHOP.Data.Repositories;
using SHOP.Model.Model;

namespace SHOP.UnitTest.RepositoryTest
{
    [TestClass]
    internal class ProductRepositoryTest
    {
        IDbFactory dbFactory;
        IProductRepository objRepository;
        IUnitOfWork unitOfWork;
        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new ProductRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }
        [TestMethod]
        public void Product_Repository_Test()
        {
            Product product = new Product();
            product.Name = "testP Product";

        }
    }
}