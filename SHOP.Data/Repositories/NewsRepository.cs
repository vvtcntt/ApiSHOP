using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface INewsRepository : IRepository<News>
    {

    }
   public class NewsRepository:RepositoryBase<News>,INewsRepository
    {
        public NewsRepository(DbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
