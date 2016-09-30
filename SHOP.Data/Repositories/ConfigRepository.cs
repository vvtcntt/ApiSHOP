using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IConfigRepository : IRepository<Config> { }
    public class ConfigRepository:RepositoryBase<Config>, IConfigRepository
    {
        public ConfigRepository (DbFactory dbFactory):base(dbFactory)
        { }
    }
}
