using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IProductConnectRepository : IRepository<ProductConnect> { }
   public class ProductConnectRepository:RepositoryBase<ProductConnect>, IProductConnectRepository
    {
        public ProductConnectRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
