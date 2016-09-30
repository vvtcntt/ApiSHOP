using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IFilesRepository : IRepository<Files> { }
  public  class FilesRepository:RepositoryBase<Files>, IFilesRepository
    {
        public FilesRepository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
