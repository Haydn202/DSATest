namespace DSA.Linear;

public class ArrayStack<T>
{
    private Array _stack = new T[10];
    private int _size = 0;

    public void Push(T value)
    {
        if (_size == _stack.Length)
        {
            IncreaseStackLength();
        }
        
        _stack.SetValue(value, _size);
        ++_size;
    }

    public object? Pop()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Empty");
        }

        --_size;
        return _stack.GetValue(_size);
    }

    public object? Peek()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Empty");
        }
        
        return _stack.GetValue(_size - 1);
    }

    public void Clear()
    {
        _size = 0;
    }

    private void IncreaseStackLength()
    {
        var resizedStack = new T[_size * 2];
        _stack.CopyTo(resizedStack, 0);
        _stack = resizedStack;
    }
}
