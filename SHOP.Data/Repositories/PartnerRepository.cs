using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IPartnerRepository : IRepository<Partner> { }
   public class PartnerRepository:RepositoryBase<Partner>
    {
        public PartnerRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
