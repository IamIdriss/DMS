
using Microsoft.EntityFrameworkCore;

namespace DMS.Data.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class 
    {
        private AppDbContext _context = null;
        private DbSet<TEntity> table = null;

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

        public IEnumerable<TEntity> GetAll()
        {
            return table.ToList();
        }

        public TEntity GetById(object id)
        {
            return table.Find(id);
        }

        public async Task InsertAsync(TEntity obj)
        {
           await table.AddAsync(obj);
        }

        public void Update(TEntity obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            TEntity existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
   
}
