using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IManufacturesRepository : IRepository<Manufactures> { }

    public class ManufacturesRepository : RepositoryBase<Manufactures>, IManufacturesRepository
    {
        public ManufacturesRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}