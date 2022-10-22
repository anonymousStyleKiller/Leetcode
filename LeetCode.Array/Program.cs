using BinaryTree;
using LinkedList;

var a = new Node('a');
var b = new Node('a');
var c = new Node('c');
var d = new Node('d');
var e = new Node('e');
var f = new Node('f');

a.Left = b;
a.Right = c;
b.Left = d;
b.Right = e;
c.Right = f;

depthFirstValues.FirstValues(a);
