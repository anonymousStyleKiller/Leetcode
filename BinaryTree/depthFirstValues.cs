namespace BinaryTree;

public static class depthFirstValues
{
    public static void FirstValues(Node root)
    {
        var stack = new Stack<Node>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            Console.WriteLine(current.Value);
            if (current.Left != null) stack.Push(current.Left);
            if (current.Right != null) stack.Push(current.Right);
        }
    }
}