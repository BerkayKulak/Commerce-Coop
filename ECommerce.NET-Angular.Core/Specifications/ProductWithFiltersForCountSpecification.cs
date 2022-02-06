using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;

namespace ECommerce.NET_Angular.Core.Specifications
{
    public class ProductWithFiltersForCountSpecification:BaseSpecification<Product>
    {
        public ProductWithFiltersForCountSpecification(ProductSpecParams productSpecParams):
            base(x =>
                (string.IsNullOrWhiteSpace(productSpecParams.Search) || x.Name.ToLower().Contains(productSpecParams.Search))
                &&
                (!productSpecParams.BrandId.HasValue || x.ProductBrandId == productSpecParams.BrandId)
                &&
                (!productSpecParams.TypeId.HasValue || x.ProductTypeId == productSpecParams.TypeId))

        {
            
        }
    }
}
