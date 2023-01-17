namespace Fred.API.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository Category { get; }

        Task SaveAsync();
    }
}
