using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System.Collections.Generic;
using System.Linq;

namespace SHOP.Data.Repositories
{
    public interface IGroupProductRepository : IRepository<GroupProduct>
    {
        IEnumerable<GroupProduct> GetByAlias(string alias);
    }

    public class GroupProductRepository : RepositoryBase<GroupProduct>, IGroupProductRepository
    {
        public GroupProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<GroupProduct> GetByAlias(string alias)
        {
            return this.DbContext.GroupProducts.Where(x => x.Alias == alias);
        }
    }
}