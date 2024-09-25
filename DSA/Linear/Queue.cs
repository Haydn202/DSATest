namespace DSA.Linear;

public class Queue<T>
{
    private Node<T> _first;
    private Node<T> _last;
    public int Length = 0;

    public T Peek()
    {
        if (Length is 0)
        {
            throw new Exception("No items to Peek!");
        }
        return _first.Value;
    }

    public void Enqueue(T value)
    {
        var item = new Node<T>(value);
        
        if (Length is 0)
        {
            _first = item;
            _last = item;
        }
        else
        {
            _last.Next = item;
            _last = item;
        }

        Length++;
    }

    public T Dequeue()
    {
        if (Length is 0)
        {
            throw new Exception("No items to Dequeue!");
        }

        var currentFirst = _first;

        _first = _first.Next;
        Length--;

        return currentFirst.Value;
    }
}