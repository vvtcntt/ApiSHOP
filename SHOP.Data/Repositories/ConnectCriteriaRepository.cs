using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IConnectCriteriaRepository : IRepository<ConnectCriteria> { }
    public class ConnectCriteriaRepository:RepositoryBase<ConnectCriteria>
    {
        public ConnectCriteriaRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
