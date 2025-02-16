using CSharpFeaturesTraining.Entities;

namespace CSharpFeaturesTraining.Repositories;

public class ListRepository<T> : IRepository<T> where T : IEntityBase,new() 
{
    protected readonly List<T> _items = new List<T>();

    public IEnumerable<T> GetAll()
    {
       return _items.ToList();
    }

    public T CreateItem()
    {
       return new T();
    }
    public T? GetById(int id)
    {
        return _items.Single(c => c.Id == id);

    }

    public void Add(T items) => _items.Add(items);
    public void Remove(T items)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}