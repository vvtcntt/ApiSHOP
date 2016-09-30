using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IConnectWebsRepository : IRepository<ConnectWebs> { }
   public class ConnectWebsRepository:RepositoryBase<ConnectWebs>, IConnectWebsRepository
    {
        public ConnectWebsRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
