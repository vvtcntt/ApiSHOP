using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IRegisterRepository : IRepository<Register>
    {
    }
   public class RegisterRepository:RepositoryBase<Register>, IRegisterRepository
    {
        public RegisterRepository(DbFactory dbFactory):base(dbFactory){ }
    }
}
