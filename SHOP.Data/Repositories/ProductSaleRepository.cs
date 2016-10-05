using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IProductSaleRepository : IRepository<ProductSale> { }

    public class ProductSaleRepository : RepositoryBase<ProductSale>
    {
        public ProductSaleRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}