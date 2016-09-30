using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{public interface IGroupImageRepository : IRepository<GroupImage> { }
    public class GroupImageRepository:RepositoryBase<GroupImage>, IGroupImageRepository
    {
        public GroupImageRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
