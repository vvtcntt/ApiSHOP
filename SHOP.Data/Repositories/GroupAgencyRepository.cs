using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IGroupAgencyRepository : IRepository<GroupAgency> { }
 public class GroupAgencyRepository:RepositoryBase<GroupAgency>, IGroupAgencyRepository
    {
        public GroupAgencyRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
