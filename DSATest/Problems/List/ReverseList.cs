namespace DSATest.Problems.List;

public abstract class ReverseList<T>
{
    public static List<T> ReverseLinkedList(List<T> list)
    {
        var stack = new Stack<T>();
        var reversedList = new List<T>();
        

        foreach (var item in list)
        {
            stack.Push(item);
        }

        while (stack.Count > 0)
        {
            reversedList.Add(stack.Pop());
        }

        return reversedList;
    }

    public static void ListToString(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}