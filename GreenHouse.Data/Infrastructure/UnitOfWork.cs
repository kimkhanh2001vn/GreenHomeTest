namespace GreenHouse.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private GreenHouseDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public GreenHouseDbContext DbContext
        {
            get
            {
                return dbContext ?? (dbContext = dbFactory.init());
            }
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}