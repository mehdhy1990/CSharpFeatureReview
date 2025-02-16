namespace CSharpFeaturesTraining.Entities;

public class Organization : EntityBase
{
  
    public string? FirstName { get; set; }

    public override string ToString() => $"FirstName: {FirstName} Id: {Id}";
}