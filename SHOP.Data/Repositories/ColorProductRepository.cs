using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IColorProductRepository : IRepository<ColorProduct> { }
    class ColorProductRepository:RepositoryBase<ColorProduct>, IColorProductRepository
    {
        public ColorProductRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
