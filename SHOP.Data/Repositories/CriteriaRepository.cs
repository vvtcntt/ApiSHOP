using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface ICriteriaRepository { }
    public class CriteriaRepository:RepositoryBase<Criteria>, ICriteriaRepository
    {
        public CriteriaRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
