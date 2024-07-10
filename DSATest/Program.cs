// See https://aka.ms/new-console-template for more information

/*var linkedList = new DSA.Linear.LinkedList<int>();

linkedList.Append(1);
linkedList.Append(3);

linkedList.Insert(2, 1);

Console.WriteLine(linkedList.Pop());

linkedList.PrintList();*/

var stack = new DSA.Linear.ArrayStack<int>();

stack.Push(1);
stack.Push(2);
stack.Push(3);
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
