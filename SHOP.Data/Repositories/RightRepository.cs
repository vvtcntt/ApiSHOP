using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IRightRepository : IRepository<Right> { }

    public class RightRepository : RepositoryBase<Right>, IRightRepository
    {
        public RightRepository(DbFactory dbFactory) : base(dbFactory)
        { }
    }
}