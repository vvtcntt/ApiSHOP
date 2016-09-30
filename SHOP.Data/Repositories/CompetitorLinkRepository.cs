using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface ICompetitorLinkRepository : IRepository<CompetitorLink>
    {

    }
   public class CompetitorLinkRepository:RepositoryBase<CompetitorLink>, ICompetitorLinkRepository
    {
        public CompetitorLinkRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }
}
