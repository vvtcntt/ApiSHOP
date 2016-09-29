﻿using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IProductSynRepository { }

    public class ProductSynRepository : RepositoryBase<ProductSyn>, IProductSynRepository
    {
        public ProductSynRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}