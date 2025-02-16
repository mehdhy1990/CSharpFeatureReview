using CSharpFeaturesTraining.Entities;

namespace CSharpFeaturesTraining.Repositories;

public interface IReadRepository<out T>
{
    IEnumerable<T> GetAll();
    T CreateItem();
    T? GetById(int id);
}
public interface IRepository< T> : IReadRepository<T> where T : IEntityBase
{
   
    void Add(T items);
    void Remove(T items);
    void Save();
}

