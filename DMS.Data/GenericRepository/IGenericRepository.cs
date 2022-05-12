namespace DMS.Data.GenericRepository
{
    public interface IGenericRepository<T>where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        Task InsertAsync(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}
