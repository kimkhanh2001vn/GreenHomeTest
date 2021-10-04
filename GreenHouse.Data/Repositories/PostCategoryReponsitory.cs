using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace GreenHouse.Data.Repositories
{
    public interface IPostCategoryReponsitory : IRepository<PostCategory>
    {
        IEnumerable<PostCategory> GetByAlias(string alias);
    }

    public class PostCategoryReponsitory : RepositoryBase<PostCategory> , IPostCategoryReponsitory
    {
        public PostCategoryReponsitory(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<PostCategory> GetByAlias(string alias)
        {
            return this.DbContext.postCategories.Where(x => x.Alias == alias);
        }
    }
}