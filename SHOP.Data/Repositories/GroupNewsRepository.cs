using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IGroupNewsRepository : IRepository<GroupNews>
    {

    }
    public class GroupNewsRepository:RepositoryBase<GroupNews>,IGroupNewsRepository
    {
        public GroupNewsRepository(DbFactory dbFacroty):base(dbFacroty)
        {

        }
    }
}
