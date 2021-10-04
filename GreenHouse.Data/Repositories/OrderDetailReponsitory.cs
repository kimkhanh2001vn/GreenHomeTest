using GreenHouse.Data.Infrastructure;
using GreenHouse.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.Data.Repositories
{
    public interface IOrderDetailReponsitory : IRepository<OrderDetail>
    {
    }

    public class OrderDetailReponsitory : RepositoryBase<OrderDetail> , IOrderDetailReponsitory
    {
        public OrderDetailReponsitory(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
