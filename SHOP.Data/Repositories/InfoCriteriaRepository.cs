using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IInfoCriteriaRepository : IRepository<InfoCriteria> { }
   public class InfoCriteriaRepository:RepositoryBase<InfoCriteria>
    {
        public InfoCriteriaRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
