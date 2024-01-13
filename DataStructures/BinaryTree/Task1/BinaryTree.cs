using System.Security.Cryptography.X509Certificates;

namespace Program;
public class Node 
{
    public Node left;
    public Node right;
    public int value;
    public Node(int val) 
    {
        value = val;
    }
    public Node() {}
}
public class BinaryTree
{
    public Node tree;
    public Node currentNode;
    public BinaryTree() {}

    public void Add(int val) 
    {
        Node node = new Node();
        node.value = val;
        while (true) 
        {
            if (tree == null) {
                tree = node;
                return;
            }
            currentNode = tree;
            if (currentNode.value < val) 
            {
                if (currentNode.right == null) 
                {
                    Node newNode = new Node(val);
                    currentNode.right = newNode;
                    return;
                }
                currentNode = currentNode.right;
                Add(currentNode, val);
                return;
            }
            if (currentNode.value >= val)
            {
                if (currentNode.left == null)
                {
                    Node newNode = new Node(val);
                    currentNode.left = newNode;
                    return;
                }
                currentNode = currentNode.left;
                Add(currentNode, val);
                return;
            }
        }
    }
    public void Add(Node current, int val)
    {
        currentNode = current;
        if (currentNode.value < val ) 
        {
            if (currentNode.right == null) 
            {
                Node newNode = new Node(val);                
                currentNode.right = newNode;
                return;
            }
            currentNode = currentNode.right;
            Add(currentNode,val);
            return;
        }
        if (currentNode.value >= val)
        {
            if (currentNode.left == null)
            {
                Node newNode = new Node(val);
                currentNode.left = newNode;
                return;
            }
            currentNode = currentNode.left;
            Add(currentNode, val);
            return;
        }
    }
}