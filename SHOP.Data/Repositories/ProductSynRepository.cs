using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IProductSynRepository : IRepository<ProductSyn> { }

    public class ProductSynRepository : RepositoryBase<ProductSyn>, IProductSynRepository
    {
        public ProductSynRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}