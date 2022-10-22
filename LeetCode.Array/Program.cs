
using BT;

var a = new TreeNode<string>("A");
var b = new TreeNode<string>("B");
var c = new TreeNode<string>("C");
var d = new TreeNode<string>("D");
var f = new TreeNode<string>("F");

a.left = b;
a.right = c;
b.left = d;
c.right = f;

var st = new Deth<string>();
st.DepthFirstValue(a);

