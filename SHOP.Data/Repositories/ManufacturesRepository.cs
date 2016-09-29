using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IManufacturesRepository { }

    public class ManufacturesRepository : RepositoryBase<Manufactures>, IManufacturesRepository
    {
        public ManufacturesRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}