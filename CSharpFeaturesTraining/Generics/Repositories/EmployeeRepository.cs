﻿using CSharpFeaturesTraining.Entities;

namespace CSharpFeaturesTraining.Repositories;

public class EmployeeRepository
{
    private readonly List<Employee> _employees = new List<Employee>();

    public void Add(Employee employee) => _employees.Add(employee);

    public void Save()
    {
        foreach (var employee in _employees)
        {
            Console.WriteLine(employee);
        }
    }
}