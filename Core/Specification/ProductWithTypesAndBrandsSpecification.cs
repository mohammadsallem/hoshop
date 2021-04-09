using System;
using System.Linq.Expressions;
using Core.Enitity;

namespace Core.Specification
{
    public class ProductWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductWithTypesAndBrandsSpecification(){
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }

        public ProductWithTypesAndBrandsSpecification(int id) : base(x => x.Id == id)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
    }
}