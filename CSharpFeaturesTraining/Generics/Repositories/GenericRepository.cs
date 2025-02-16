﻿using CSharpFeaturesTraining.Entities;

namespace CSharpFeaturesTraining.Repositories;

public class GenericRepository<T> where T : class ,IEntityBase,new()
{
    protected readonly List<T> _items = new List<T>();

    public T CreateItem()
    {
       return new T();
    }
    public T? GetById(int id)
    {
        return _items.Single(c => c.Id == id);
        return null;
    }

    public void Add(T items) => _items.Add(items);

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}

public class GenericRepositoryWithRemove<T> : GenericRepository<T> where T : EntityBase,new()
{
    public void Remove(T item) => _items.Remove(item);
}