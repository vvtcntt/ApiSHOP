﻿using SHOP.Data.Infratructure;
using SHOP.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Data.Repositories
{
    public interface IConnectNewsRepository : IRepository<ConnectNews> { }
    public class ConnectNewsRepository:RepositoryBase<ConnectNews>, IConnectNewsRepository
    {
        public ConnectNewsRepository(DbFactory dbFactory):base(dbFactory)
        { }
    }

}
