namespace CSharpFeaturesTraining;

class Program
{
    static void Main(string[] args)
    {
        StackDoubles();
    }

    private static void StackDoubles()
    {
        var stack = new SimpleStack();
        stack.Push(2.0);
        stack.Push(3.5);
        stack.Push(1.0);
        while (stack.Count>0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}