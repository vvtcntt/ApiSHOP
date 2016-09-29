using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IUserRepository { }
   public class UserRepository:RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DbFactory dbFactory) : base(dbFactory) {  }
    }
}
