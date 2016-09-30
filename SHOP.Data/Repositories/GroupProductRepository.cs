
using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace SHOP.Data.Repositories
{
    public interface iGroupProductRepository : IRepository<GroupProduct>
    {
        IEnumerable<GroupProduct> GetByAlias(string alias);
    }
    class GroupProductRepository : RepositoryBase<GroupProduct>,iGroupProductRepository
    {
        
        public GroupProductRepository(DbFactory dbFactory):base(dbFactory)
            {

            }

        public IEnumerable<GroupProduct> GetByAlias(string alias)
        {
            return this.DbContext.GroupProducts.Where(x => x.Alias == alias);
        }
    }
}
