using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Core.Specifications
{
    public class ProductsWithFilterForCountSpecification : BaseSpecification<Product>
    {
        public ProductsWithFilterForCountSpecification(ProductSpecParams productParams)
             : base(p => (string.IsNullOrEmpty(productParams.Search) || p.Name.ToLower().Contains(productParams.Search)) &&
                         (!productParams.BrandId.HasValue || p.ProductBrandId == productParams.BrandId) &&
                         (!productParams.TypeId.HasValue || p.ProductTypeId == productParams.TypeId))

        {

        }

    }
}
