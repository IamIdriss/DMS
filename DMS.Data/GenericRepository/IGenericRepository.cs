namespace DMS.Data.GenericRepository
{
    public interface IGenericRepository<T>where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task InsertAsync(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
