namespace Domain.Interfaces;

public interface IRepositoryBase<T>
{
    Task Create(T objectToBeCreated);
    Task Delete(T objectToBeDeleted);
    Task Delete(Guid id);
    Task<T> Update(T objectedToBeUpdated);
    Task<T> Get(Guid id);
    Task SaveChanges();
}