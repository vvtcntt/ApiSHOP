using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{public interface IHistoryLoginRepository : IRepository<HistoryLogin> { }
   public class HistoryLoginRepository: RepositoryBase<HistoryLogin>, IHistoryLoginRepository
    {
        public HistoryLoginRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
