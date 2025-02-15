using CSharpFeaturesTraining.Entities;

namespace CSharpFeaturesTraining.Repositories;

public class GenericRepository<T>
{
    protected readonly List<T> _items = new List<T>();

    public void Add(T items) => _items.Add(items);

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}

public class GenericRepositoryWithRemove<T> : GenericRepository<T>
{
    public void Remove(T item) => _items.Remove(item);
}