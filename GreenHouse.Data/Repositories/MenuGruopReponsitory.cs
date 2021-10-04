using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;

namespace GreenHouse.Data.Repositories
{
    public interface IMenuGruopReponsitory : IRepository<MenuGruop>
    {
    }

    public class MenuGruopReponsitory : RepositoryBase<MenuGruop> , IMenuGruopReponsitory
    {
        public MenuGruopReponsitory(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}