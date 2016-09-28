using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Infratructure
{
    public class DbFactory:Disposable,IDbFactory
    {
        private SHOPDbContext dbContext;
        public SHOPDbContext init()
        {
            return dbContext ?? (dbContext = new SHOPDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext!=null)
            base.DisposeCore();
        }
    }
}
