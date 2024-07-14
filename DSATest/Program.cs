// See https://aka.ms/new-console-template for more information

/*var linkedList = new DSA.Linear.LinkedList<int>();

linkedList.Append(1);
linkedList.Append(3);

linkedList.Insert(2, 1);

Console.WriteLine(linkedList.Pop());

linkedList.PrintList();*/

var queue = new DSA.Linear.Queue<String>();

queue.Enqueue("Google");
queue.Enqueue("Udemy");
queue.Enqueue("Discord");

while (queue.Length > 0)
{
    Console.WriteLine(queue.Dequeue());
}