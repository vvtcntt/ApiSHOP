﻿using SHOP.Data.Infratructure;
using SHOP.Model.Model;

namespace SHOP.Data.Repositories
{
    public interface IProductSaleRepository { }

    public class ProductSaleRepository : RepositoryBase<ProductSale>
    {
        public ProductSaleRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}