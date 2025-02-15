using System.Security.AccessControl;

namespace CSharpFeaturesTraining;

internal class SimpleStack<T>
{
    private readonly T[] _items;
    private int _currentIndex = -1;
    public int Count => _currentIndex+1;
    public SimpleStack()
    {
        _items = new T[10];
    }

    public void Push(T Item) => _items[++_currentIndex] = Item;


    public T Pop() => _items[_currentIndex--];
}