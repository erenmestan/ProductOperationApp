namespace ProductOperation.Core.Services
{
    public interface IService<T>
    {
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> GetAll();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
    }
}
