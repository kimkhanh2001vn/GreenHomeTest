using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace GreenHouse.Data.Repositories
{
    public interface IPostReponsitory : IRepository<Post>
    {
        IEnumerable<Post> GetByAlias(string alias);
        IEnumerable<Post> GetAllByTag(string tag, int page, int pagesize, out int totaRow);
    }

    public class PostReponsitory : RepositoryBase<Post>, IPostReponsitory
    {
        public PostReponsitory(DbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pagesize, out int totaRow)
        {
            var query = from a in DbContext.posts
                        join b in DbContext.postTags on a.ID equals b.PostID
                        where b.TagID == tag && a.Status == true
                        orderby a.CreateDate descending
                        select a;

            totaRow = query.Count();

            query = query.Skip((pageIndex - 1) * pagesize).Take(pagesize);

            return query;
        }

        public IEnumerable<Post> GetByAlias(string alias)
        {
            return this.DbContext.posts.Where(x => x.Alias == alias);
        }
    }
}