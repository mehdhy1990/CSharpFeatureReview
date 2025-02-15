using System.Security.AccessControl;

namespace CSharpFeaturesTraining;

internal class SimpleStack
{
    private readonly double[] _items;
    private int currentIndex = -1;
    public int Count => currentIndex+1;
    public SimpleStack()
    {
        _items = new double[10];
    }

    public void Push(double number) => _items[++currentIndex] = number;


    public double Pop() => _items[currentIndex--];
}