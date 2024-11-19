public class TraversalBinaryTree
{
    public static void Run()
    {
        var one = new TreeNode(1);
        var two = new TreeNode(2);
        var three = new TreeNode(3);
        var four = new TreeNode(4);
        var five = new TreeNode(5);
        var six = new TreeNode(6);
        var seven = new TreeNode(7);

        /*
                    4
                2       6
              1   3   5   7
        */
        four.Left = two;
        four.Right = six;
        two.Left = one;
        two.Right = three;
        six.Left = five;
        six.Right = seven;

        Execute();
    }

    // TODO: Implement here...
    private static void Execute()
    {
        // PreOrderTraversal();
        // InOrderTraversal();
        // PostOrderTraversal();
        // LevelOrderTraversal();
    }
}