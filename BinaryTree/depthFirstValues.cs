namespace BinaryTree;

public static class depthFirstValues
{
    public static void FirstValues(Node root)
    {
        var stack = new Stack<Node>();

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            Console.WriteLine(current.Value);
            if (current.Left != null) stack.Push(root.Left);
            if (current.Left != null) stack.Push(root.Right);
        }
    }
}