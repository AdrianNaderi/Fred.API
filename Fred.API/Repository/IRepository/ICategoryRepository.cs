using Fred.Models.Entities.SpotEntity;

namespace Fred.API.Repository.IRepository
{
    public interface ICategoryRepository : IBaseRepository<CategoryEntity>
    {
        Task UpdateAsync(CategoryEntity entity);
    }
}
