
using Microsoft.EntityFrameworkCore;

namespace DMS.Data.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class 
    {
        private AppDbContext _context;
        private DbSet<TEntity> table;

        public GenericRepository()
        {
            this._context = new AppDbContext();
            table = _context.Set<TEntity>();
        }

        public GenericRepository(AppDbContext _context)
        {
            this._context = _context;
            table = _context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(object id)
        {
            return (await table.FindAsync(id));
        }

        public async Task InsertAsync(TEntity obj)
        {
           await table.AddAsync(obj);
           Save();
        }

        public void Update(TEntity obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
            _context.Update(obj);
            Save();
        }

        public void Delete(object id)
        {
            TEntity existing = table.Find(id);
            table.Remove(existing);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

 
    }
   
}
