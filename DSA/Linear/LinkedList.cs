namespace DSA.Linear;

public class LinkedList<T>
{
    private Node<T> Head { get; set; }
    private Node<T> Tail { get; set; }
    private int _length = 0;

    // Add node to end of list O(1)
    public void Append(T value)
    {
        var node = new Node<T>(value);

        if (Head is not null)
        {
            Tail.Next = node;
            Tail = node;
        }
        else
        {
            Head = node;
            Tail = node;
        }

        ++_length;
    }

    public void Prepend(T value)
    {
        var node = new Node<T>(value);

        if (_length == 0)
        {
            Head = node;
            Tail = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }

        ++_length;
    }

    public void Insert(T value, int index)
    {
        if (index > _length)
        {
            throw new ArgumentException(
                "Index out of bounds of the list."
                );
        }

        if (index == 0)
        {
            Prepend(value);
            return;
        }
        
        var node = new Node<T>(value);
        var current = Head;
        var previous = Head;
        var position = 0;

        while (position != index)
        {
            previous = current;
            current = current.Next;
            ++position;
        }

        previous.Next = node;
        node.Next = current;

        ++_length;
    }

    public object? Pop()
    {
        if (_length == 0)
        {
            return null;
        }

        var current = Head;
        var previous = Head;

        while (current.Next is not null)
        {
            previous = current;
            current = current.Next;
        }

        Tail = previous;
        Tail.Next = null;
        --_length;

        if (_length == 0)
        {
            Head = null;
            Tail = null;
        }

        return current.Value;
    }

    public void PrintList()
    {
        var temp = Head;

        while (temp.Next is not null)
        {
            Console.WriteLine(temp.Value);
            temp = temp.Next;
        }
        Console.WriteLine(temp.Value);
    }
}