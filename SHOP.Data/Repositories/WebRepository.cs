using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IWebRepository : IRepository<Web>
    {

    }
    public class WebRepository:RepositoryBase<Web>, IWebRepository
    {
        public WebRepository(DbFactory dbFactory):base(dbFactory)
        {  }
    }
}
