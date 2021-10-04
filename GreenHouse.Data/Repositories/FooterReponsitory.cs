using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;

namespace GreenHouse.Data.Repositories
{
    public interface IFooterReponsitory : IRepository<Footer>
    {
    }

    public class FooterReponsitory : RepositoryBase<Footer> , IFooterReponsitory
    {
        public FooterReponsitory(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}