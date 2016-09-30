using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IBanksRepository : IRepository<Banks>
    {
    }
    public class BanksRepository: RepositoryBase<Banks>, IBanksRepository
    {
        public BanksRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
