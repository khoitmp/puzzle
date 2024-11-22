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

        // 3 -> 2 -> 1
        var node = Execute(node1);
    }

    // TODO: Implement here...
    private static LinkedListNode Execute(LinkedListNode node)
    {
        throw new NotImplementedException();
    }
}