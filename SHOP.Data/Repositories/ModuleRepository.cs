using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IModuleRepository : IRepository<Module> { }
    public class ModuleRepository:RepositoryBase<Module>, IModuleRepository
    {
        public ModuleRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
