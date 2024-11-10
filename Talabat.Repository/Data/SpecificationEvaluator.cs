using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;
using Talabat.Core.Specifications;

namespace Talabat.Repository.Data
{
    internal class SpecificationEvaluator<T> where T : BaseEntity
    {
        //=> Where(item=> item.Id == id).include(p=>p.productBrand).include(p=>p.productType);
        public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpecification<T> spec)
        {

            var query = inputQuery;

            if (spec.Criteria != null)
                query = query.Where(spec.Criteria);

            if(spec.IsPaginationEnabled)
                query = query.Skip(spec.Skip).Take(spec.Take);

            if (spec.OrderBy != null)
                query = query.OrderBy(spec.OrderBy);
            if(spec.OrderByDescending!=null)
                query = query.OrderByDescending(spec.OrderByDescending);

            query = spec.Includes.Aggregate(query, (currentQuery, includeExpression) => currentQuery.Include(includeExpression));


            return query;

        }

    }
}
