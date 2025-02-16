namespace CSharpFeaturesTraining.Entities;

public class Employee : EntityBase
{
  
    public string? FirstName { get; set; }

    public override string ToString() => $"FirstName: {FirstName} Id: {Id}";
}