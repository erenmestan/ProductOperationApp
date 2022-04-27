namespace ProductOperation.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
