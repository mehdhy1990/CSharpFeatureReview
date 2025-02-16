﻿using CSharpFeaturesTraining.Data;
using CSharpFeaturesTraining.Entities;
using CSharpFeaturesTraining.Repositories;

namespace CSharpFeaturesTraining;

class Program
{
    static void Main(string[] args)
    {
        var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
       AddEmployee(employeeRepository);
       GetEmployeeById(employeeRepository);
        employeeRepository.Save();
    }

    private static void GetEmployeeById(IRepository<Employee> employeeRepository)
    {
        var employee = employeeRepository.GetById(2);
        Console.WriteLine($"Employee ID 2: {employee.FirstName}");
    }

    private static void AddEmployee(IRepository<Employee> employeeRepository)
    {
        employeeRepository.Add(new Employee(){FirstName = "Julia"});
        employeeRepository.Add(new Employee(){FirstName = "asghar"});
        employeeRepository.Add(new Employee(){FirstName = "Akbar"});
        employeeRepository.Save();
    }

    private static void AddOrganization(ListRepository<Organization> OrganizationRepository)
    {
        OrganizationRepository.Add(new Organization(){FirstName = "pluralSight"});
        OrganizationRepository.Save();
    }
    
    

    
}