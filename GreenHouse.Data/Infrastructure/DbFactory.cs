using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenHouse.Data.Infrastructure
{
    public class DbFactory : Disposable , IDbFactory
    {
        private GreenHouseDbContext dbContext;
        public GreenHouseDbContext init()
        {
            return dbContext ?? (dbContext = new GreenHouseDbContext());
        }
        protected override void DisposeCore()
        {
            if(dbContext != null)
            
               dbContext.Dispose();
        }
    }
}
