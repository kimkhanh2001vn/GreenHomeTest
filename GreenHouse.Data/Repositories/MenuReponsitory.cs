using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;

namespace GreenHouse.Data.Repositories
{
    public interface IMenuReponsitory : IRepository<Menu>
    {
    }

    public class MenuReponsitory : RepositoryBase<Menu> , IMenuReponsitory
    {
        public MenuReponsitory(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}