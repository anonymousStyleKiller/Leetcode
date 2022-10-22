namespace BinaryTree;

public class Node
{
    public object Value { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
    
    public Node(object value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}