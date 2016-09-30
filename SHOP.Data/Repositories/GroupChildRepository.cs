using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IGroupChildRepository : IRepository<GroupChild> { }

    public class GroupChildRepository : RepositoryBase<GroupChild>, IGroupChildRepository
    {
        public GroupChildRepository(DbFactory dbFactory) : base(dbFactory)
        { }
    }
}