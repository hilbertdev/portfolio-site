using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Domain.Repositories;

public class GenericRepository<TEntity> where TEntity : class
{
    internal Context context;
    internal DbSet<TEntity> dbSet;

    public GenericRepository(Context context)
    {
        context = context;
        dbSet = context.Set<TEntity>();
    }

    public async Task<IEnumerable<TEntity>> Get(
        Expression<Func<TEntity, bool>>? filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
        string includeProperties = "")
    {
        IQueryable<TEntity> query = dbSet;

        if (filter != null)
        {
            query = query.Where(filter);
        }

        foreach (var includeProperty in includeProperties.Split
                     (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty);
        }

        if (orderBy != null)
        {
            return orderBy(query).ToList();
        }
        else
        {
            return query.ToList();
        }
    }

    public async Task<TEntity?> GetByID(object id)
    {
        return await dbSet.FindAsync(id);
    }

    public async Task Insert(TEntity entity)
    {
        await dbSet.AddAsync(entity);
    }

    public async Task Delete(object id)
    {
        var entityToDelete = await dbSet.FindAsync(id);
        if (entityToDelete != null)
        {
            Delete(entityToDelete);
        }
    }

    public void Delete(TEntity entityToDelete)
    {
        if (context.Entry(entityToDelete).State == EntityState.Detached)
        {
            dbSet.Attach(entityToDelete);
        }

        dbSet.Remove(entityToDelete);
    }

    public  void Update(TEntity entityToUpdate)
    {
        dbSet.Attach(entityToUpdate);
        context.Entry(entityToUpdate).State = EntityState.Modified;
    }
}