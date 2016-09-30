using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IConnectImagesRepository : IRepository<ConnectImages> { }
    public class ConnectImagesRepository:RepositoryBase<ConnectImages>
    {
        public ConnectImagesRepository(DbFactory dbFactory):base(dbFactory)
        {  }
    }
}
