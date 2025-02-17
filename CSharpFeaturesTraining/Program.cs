using CSharpFeaturesTraining.Data;
using CSharpFeaturesTraining.Entities;
using CSharpFeaturesTraining.Repositories;

namespace CSharpFeaturesTraining;

class Program
{
    static void Main(string[] args)
    {
        IProduce<Derived> produce = null;
        Base b = produce.Produce();
        Derived d = produce.Produce();
        IConsumer<Base> consumer = null;
        consumer.Consume(new Base());
        consumer.Consume(new Derived());
        
        
       
        
    }
}

interface IProduce<out T>
{
    T Produce();
}

interface IConsumer<in T>
{
    void Consume(T t);
}
public class Base
{
    public void DoSomething()=> Console.WriteLine($"Doing from {this.GetType().Name}");
}

public class Derived : Base
{
    
}