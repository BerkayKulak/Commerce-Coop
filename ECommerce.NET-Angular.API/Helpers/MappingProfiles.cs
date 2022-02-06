using AutoMapper;
using ECommerce.NET_Angular.API.Dtos;
using ECommerce.NET_Angular.Core.DbModels;

namespace ECommerce.NET_Angular.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>();
        }
    }
}
