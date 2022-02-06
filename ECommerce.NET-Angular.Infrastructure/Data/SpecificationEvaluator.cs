using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.NET_Angular.Core.DbModels;
using ECommerce.NET_Angular.Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.NET_Angular.Infrastructure.Data
{
    public class SpecificationEvaluator<TEntity> where TEntity : BaseEntity
    {
        // GetQuery sonucunda bana bir liste dönülecek o yüzden IQueryable yaptım. henüz sorgumu databaseden getirmedim. devam ediyorum uygulamaya
        // dışarıdan bana bir inputQuery gelicek diyorum.
        // spec ise benden istenen kriterlerdir diyorum.

        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery,ISpecification<TEntity> spec)
        {
            var query = inputQuery;

            // uygulanmasını istenen koşul içinde bir koşul var mı mesela idsi şu olanları getir gibi

            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);
            }

            if (spec.OrderBy != null)
            {
                query = query.OrderBy(spec.OrderBy);
            }

            if (spec.OrderByDescending != null)
            {
                query = query.OrderByDescending(spec.OrderByDescending);
            }

            // yoksa aggregate yapıp işlemi gerçekleştiriyorum. current = TEntity
            // curretnler içinde Includelar var mı varsa uygula ve geriye döndür
            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            return query;


        }
    }
}
