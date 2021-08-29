namespace GreenHouse.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}