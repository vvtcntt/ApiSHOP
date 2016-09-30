using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IOrderRepository : IRepository<Order> { }
   public class OrderRepository:RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
