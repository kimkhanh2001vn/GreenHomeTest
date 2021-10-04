using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace GreenHouse.Data.Repositories
{
    public interface IProductReponsitory : IRepository<Product>
    {
        IEnumerable<Product> GetByAlias(string alias);
    }

    public class ProductReponsitory : RepositoryBase<Product>, IProductReponsitory
    {
        public ProductReponsitory(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<Product> GetByAlias(string alias)
        {
            return this.DbContext.products.Where(x => x.Alias == alias);
        }
    }
}