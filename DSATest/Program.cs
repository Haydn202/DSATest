// See https://aka.ms/new-console-template for more information

/*var linkedList = new DSA.Linear.LinkedList<int>();

linkedList.Append(1);
linkedList.Append(3);

linkedList.Insert(2, 1);

Console.WriteLine(linkedList.Pop());

linkedList.PrintList();*/

using DSA.Linear;

var linkedStack = new ListStack<string>();

linkedStack.Push("Google");
linkedStack.Push("Udemy");
linkedStack.Push("Discord");

while (linkedStack.Length > 0)
{
    Console.WriteLine(linkedStack.Pop());
}