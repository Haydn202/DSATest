using Azure.Messaging.ServiceBus;

// See https://aka.ms/new-console-template for more information

var linkedList = new DSA.Linear.LinkedList<int>();

linkedList.Append(1);
linkedList.Append(3);

linkedList.Insert(2, 1);

Console.WriteLine(linkedList.Pop());

linkedList.PrintList();

/*using DSATest.Problems.Arrays;

int[] nums = [1,2,3,1,2,3];

var dI = new DuplicateInteger();

dI.HasDuplicate(nums);*/
