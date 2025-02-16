﻿using CSharpFeaturesTraining.Entities;

namespace CSharpFeaturesTraining.Repositories;

public interface IRepository<T> where T :  IEntityBase, new()
{
    IEnumerable<T> GetAll();
    T CreateItem();
    T? GetById(int id);
    void Add(T items);
    void Remove(T items);
    void Save();
}