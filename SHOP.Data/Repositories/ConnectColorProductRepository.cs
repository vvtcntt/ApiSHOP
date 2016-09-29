using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IConnectColorProductRepository { }
    public class ConnectColorProductRepository:RepositoryBase<ConnectColorProduct>, IConnectColorProductRepository
    {
        public ConnectColorProductRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
