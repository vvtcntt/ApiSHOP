using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IAgencyRepository : IRepository<Agency> { }
    public class AgencyRepository:RepositoryBase<Agency>, IAgencyRepository
    {
        public AgencyRepository(DbFactory dbFacroty):base(dbFacroty)
        {

        }
    }
}
