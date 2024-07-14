namespace DSA.Linear;

public class ListStack<T>
{
    private Node<T>? _top = null;
    private Node<T>? _bottom = null;
    public int Length = 0;

    public T Peek()
    {
        if (Length is 0)
        {
            throw new ArgumentException("There are no items to Peek!");
        }
        return _top.Value;
    }

    public void Push(T value)
    {
        var newValue = new Node<T>(value);
        
        if (Length is 0)
        {
            _bottom = newValue;
            _top = newValue;
        }
        else
        {
            var currentTop = _top;
            _top = newValue;
            _top.Next = currentTop;
        }
        
        Length++;
    }

    public T Pop()
    {
        if (Length is 0)
        {
            throw new ArgumentException("There are no items to Pop!");
        }

        var currentTop = _top;

        _top = _top.Next;
        Length--;
        
        return currentTop.Value;
    }
}