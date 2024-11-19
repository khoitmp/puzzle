using System;

public class LinkedListNode
{
    public int Value;
    public LinkedListNode Next;

    public LinkedListNode(int value)
    {
        Value = value;
    }

    public static void Print(LinkedListNode linkedListNode)
    {
        while (linkedListNode != null)
        {
            Console.Write($"{linkedListNode.Value} ");
            linkedListNode = linkedListNode.Next;
        }
    }
}