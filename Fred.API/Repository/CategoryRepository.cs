using Fred.API.Data;
using Fred.API.Repository.IRepository;
using Fred.Models.Entities.SpotEntity;

namespace Fred.API.Repository
{
    public class CategoryRepository : BaseRepository<CategoryEntity>, ICategoryRepository
    {
        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task UpdateAsync(CategoryEntity entity)
        {
            _db.Categories.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
