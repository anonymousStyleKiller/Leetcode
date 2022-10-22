namespace BT;

public class Deth<T>
{
    public TreeNode<T> DepthFirstValue(TreeNode<T> root)
    {
        var stack = new Stack<TreeNode<T>>();
        
        if (root != null)
        {
            stack.Push(root);
            while (stack.Count > 0)
            {
                var current = stack.Pop();
                Console.WriteLine(current.val);
                if (current.right != null) stack.Push(current.right);
                if (current.left != null) stack.Push(current.left);
            }
        }
        return root;
    }
}