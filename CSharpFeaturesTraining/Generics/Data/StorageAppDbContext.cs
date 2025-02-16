using CSharpFeaturesTraining.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpFeaturesTraining.Data;

public class StorageAppDbContext : DbContext
{
    DbSet<Employee> Employees => Set<Employee>();
    private DbSet<Organization> Organizations => Set<Organization>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseInMemoryDatabase("StorageApp");
    }
}