namespace BinaryTree;

public class Node
{
    public Node Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    
    public Node(Node value)
    {
        Left = null;
        Right = null;
        Value = value;
    }
}