using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Infratructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private SHOPDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public SHOPDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.init()); }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }

}
