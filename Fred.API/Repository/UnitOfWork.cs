using Fred.API.Data;
using Fred.API.Repository.IRepository;

namespace Fred.API.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _db;
        public UnitOfWork(AppDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
        }

        public ICategoryRepository Category { get; private set; }


        public async Task SaveAsync() => await _db.SaveChangesAsync();
    }
}
