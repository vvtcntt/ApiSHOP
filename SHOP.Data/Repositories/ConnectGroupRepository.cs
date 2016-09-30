using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IConnectGroupRepository : IRepository<ConnectGroup> { }
   public class ConnectGroupRepository:RepositoryBase<ConnectGroup>, IConnectGroupRepository
    {
        public ConnectGroupRepository(DbFactory dbFactory):base(dbFactory)
        {  }
    }
}
