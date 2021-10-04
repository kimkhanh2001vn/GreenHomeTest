using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;

namespace GreenHouse.Data.Repositories
{
    public interface IOrderReponsitory : IRepository<Order>
    {
    }

    public class OrderReponsitory : RepositoryBase<Order> ,IOrderReponsitory
    {
        public OrderReponsitory(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}