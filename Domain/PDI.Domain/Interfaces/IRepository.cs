namespace PDI.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<bool> CreateAsync(T value);
        Task<bool> UpdateAsync(T value);
        Task<bool> DeleteAsync(Guid id);
    }
}
