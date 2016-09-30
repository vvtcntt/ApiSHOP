using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IHotlineRepository : IRepository<Hotline> { }
    public class HotlineRepository:RepositoryBase<Hotline>
    {
        public HotlineRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
