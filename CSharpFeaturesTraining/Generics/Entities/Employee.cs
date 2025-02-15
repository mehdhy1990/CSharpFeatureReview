namespace CSharpFeaturesTraining.Entities;

public class Employee
{
    public int Id { get; set; }
    public string? FirstName { get; set; }

    public override string ToString() => $"FirstName: {FirstName} Id: {Id}";
}