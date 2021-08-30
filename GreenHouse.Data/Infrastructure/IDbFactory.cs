using System;

namespace GreenHouse.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        GreenHouseDbContext init();
    }
}