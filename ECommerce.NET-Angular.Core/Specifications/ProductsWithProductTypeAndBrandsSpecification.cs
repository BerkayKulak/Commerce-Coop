using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;

namespace ECommerce.NET_Angular.Core.Specifications
{
    public class ProductsWithProductTypeAndBrandsSpecification:BaseSpecification<Product>
    {
        public ProductsWithProductTypeAndBrandsSpecification(string sort)
        {
            AddInclude(x=>x.ProductBrand);
            AddInclude(x=>x.ProductType);
            //AddOrderBy(x=>x.Name);

            if (!string.IsNullOrWhiteSpace(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(p=>p.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(p=>p.Price);
                        break;
                    default:
                        AddOrderBy(x=>x.Name);
                        break;
                }
            }
        }

        public ProductsWithProductTypeAndBrandsSpecification(int id)
            :base(x=>x.Id ==id)
        {
            AddInclude(x => x.ProductBrand);
            AddInclude(x => x.ProductType);
        }
    }
}
