﻿using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IUrlRepository
    {
    }

    public class UrlRepository : RepositoryBase<Url>, IUrlRepository
    {
        public UrlRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}