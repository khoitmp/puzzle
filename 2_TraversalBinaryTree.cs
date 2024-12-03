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
    }

    /* 
        TODO: Implement here...
        
        4 2 6 1 3 5 7
    */
    private static void LevelOrderTraversal()
    {
        throw new NotImplementedException();
    }

    /* 
        TODO: Implement here...
        
        4 2 1 3 6 5 7
    */
    private static void PreOrderTraversal()
    {
        throw new NotImplementedException();
    }

    /* 
        TODO: Implement here...

        1 2 3 4 5 6 7
    */
    private static void InOrderTraversal()
    {
        throw new NotImplementedException();
    }

    /* 
        TODO: Implement here...

        1 3 2 5 7 6 4
    */
    private static void PostOrderTraversal()
    {
        throw new NotImplementedException();
    }
}