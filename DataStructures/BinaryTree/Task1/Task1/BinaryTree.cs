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

    public void Remove(int val) 
    {
        if (tree == null) return;
        currentNode = tree;
        if (val < currentNode.value)
        {
            currentNode = currentNode.left;
            Remove(currentNode,val);
            return;
        }
        if (val >= currentNode.value)
        {
            currentNode = currentNode.right;
            Remove(currentNode,val);
            return;
        }
        if (val == currentNode.left.value)
        {
            currentNode = currentNode.left;
            if (currentNode.right != null && currentNode.left != null) 
            {
                currentNode = currentNode.right;
                return;
            }
            if (currentNode.right == null && currentNode.left != null)
            {
                currentNode = currentNode.left;
                return;
            }
            if (currentNode.right != null && currentNode.left == null) 
            {
                currentNode = currentNode.right;
                return;
            }
            if (currentNode.left == null && currentNode.right == null)
            {
                currentNode = null;
                return;
            }            
        }
        if (val == currentNode.right.value)
        {
            currentNode = currentNode.right;
            if (currentNode.right != null && currentNode.left != null) 
            {
                currentNode = currentNode.right;
                return;
            }
            if (currentNode.right == null && currentNode.left != null)
            {
                currentNode = currentNode.left;
                return;
            }
            if (currentNode.right != null && currentNode.left == null) 
            {
                currentNode = currentNode.right;
                return;
            }
            if (currentNode.left == null && currentNode.right == null)
            {
                currentNode = null;
                return;
            }
        }
    }
    public void Remove(Node current, int val)
    {

        if (current.left != null)
        {
        if (val == current.left.value)
        {
            current = current.left;
            if (current.right != null && current.left != null) 
            {
                current = current.right;
                return;
            }
            if (current.right == null && current.left != null)
            {
                current = current.left;
                return;
            }
            if (current.right != null && current.left == null) 
            {
                current = current.right;
                return;
            }          
        }
        }
        if (current.right != null) 
        {
        if (val == current.right.value)
        {
            Node newCurrent = current.right;
            if (newCurrent.right != null && newCurrent.left != null) 
            {
                current = current.right;
                return;
            }
            if (newCurrent.right == null && newCurrent.left != null)
            {
                current = current.left;
                return;
            }
            if (current.right != null && current.left == null) 
            {
                current = current.right;
                return;
            }
            if (current.left == null && current.right == null)
            {
                current = null;
                return;
            }
        }
        }
        
        if (val < current.value)
        {
            current = current.left;
            Remove(current,val);
            return;
        }
        if (val > current.value)
        {
            current = current.right;
            Remove(current,val);
            return;
        }
    }
}