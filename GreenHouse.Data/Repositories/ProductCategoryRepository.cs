﻿using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace GreenHouse.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
        public ProductCategoryRepository(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return this.DbContext.productCategories.Where(x => x.Alias == alias);
        }
    }
}