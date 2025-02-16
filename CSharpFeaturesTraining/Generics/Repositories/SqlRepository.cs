using CSharpFeaturesTraining.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpFeaturesTraining.Repositories;

public class SqlRepository<T> : IRepository<T> where T : class, IEntityBase, new()
{
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public SqlRepository(DbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public T CreateItem()
    {
        return new T();
    }

    public T? GetById(int id)
    {
        return _dbSet.Find(id);
        return null;
    }

    public void Add(T items) => _dbSet.Add(items);
    public void Remove(T items) => _dbSet.Remove(items);

    public void Save()
    {
        _context.SaveChanges();
    }
}