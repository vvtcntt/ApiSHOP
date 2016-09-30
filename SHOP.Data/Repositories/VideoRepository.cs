using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IVideoRepository : IRepository<Video> { }
    public class VideoRepository:RepositoryBase<Video>, IVideoRepository
    {
        public VideoRepository(DbFactory dbFactory) : base(dbFactory) {  }
    }
}
