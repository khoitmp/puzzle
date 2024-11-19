public class ReverseLinkedList
{
    public static void Run()
    {
        var node1 = new LinkedListNode(1);
        var node2 = new LinkedListNode(2);
        var node3 = new LinkedListNode(3);

        // 1 -> 2 -> 3
        node1.Next = node2;
        node2.Next = node3;

        LinkedListNode.Print(node1);

        Execute();
    }

    // TODO: Implement here...
    private static void Execute()
    {
    }
}