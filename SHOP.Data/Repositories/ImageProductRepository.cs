using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IImageProductRepository : IRepository<ImageProduct> { }
    public class ImageProductRepository:RepositoryBase<ImageProduct>, IImageProductRepository
    {
        public ImageProductRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
