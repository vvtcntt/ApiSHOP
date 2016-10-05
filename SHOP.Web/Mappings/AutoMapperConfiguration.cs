using AutoMapper;
using SHOP.Model.Model;
using SHOP.Web.Models;

namespace SHOP.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configuare()
        {
            Mapper.CreateMap<GroupProduct, GroupProductViewModel>();
            Mapper.CreateMap<Product, ProductViewModel>();
            Mapper.CreateMap<ColorProduct, ColorProductViewModel>();
            Mapper.CreateMap<ConnectColorProduct, ConnectColorProductViewModel>();
            Mapper.CreateMap<ConnectCriteria, ConnectCriteriaViewModel>();
            Mapper.CreateMap<ProductCheck, ProductCheckViewModel>();
        }
    }
}