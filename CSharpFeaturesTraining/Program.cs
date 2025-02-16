using CSharpFeaturesTraining.Data;
using CSharpFeaturesTraining.Entities;
using CSharpFeaturesTraining.Repositories;

namespace CSharpFeaturesTraining;

class Program
{
    static void Main(string[] args)
    {
        var employeeRepository = new SqlRepository<Employee>(new StorageAppDbContext());
        employeeRepository.Add(new Employee(){FirstName = "Julia"});
        employeeRepository.Add(new Employee(){FirstName = "asghar"});
        employeeRepository.Add(new Employee(){FirstName = "Akbar"});
        employeeRepository.Save();
    }

    
}