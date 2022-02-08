using AutoMapper;
using ECommerce.NET_Angular.API.Dtos;
using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.DbModels.Identity;

namespace ECommerce.NET_Angular.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>().
                ForMember(x=>x.ProductBrand,o=>o.MapFrom(s=>s.ProductBrand.Name))
                .ForMember(x=>x.ProductType,o=>o.MapFrom(s=>s.ProductType.Name))
                .ForMember(x=>x.PictureUrl, o => o.MapFrom<ProductUrlResolver>());

            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<CustomerBasketDto, CustomerBasket>();
            CreateMap<BasketItemDto, BasketItem>();
        }
    }
}
