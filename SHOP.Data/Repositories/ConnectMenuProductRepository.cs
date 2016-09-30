using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{ public interface IConnectMenuProductRepository : IRepository<ConnectMenuProduct> { }
    public class ConnectMenuProductRepository:RepositoryBase<ConnectMenuProduct>, IConnectMenuProductRepository
    {
        public ConnectMenuProductRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
