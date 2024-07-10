namespace DSA.Linear;

public interface INode<T>
{
    T Value { get; set; }
}

internal class Node<T>(T value) : INode<T>
{
    public T Value { get; set; } = value;
    public Node<T>? Next { get; set; }
}