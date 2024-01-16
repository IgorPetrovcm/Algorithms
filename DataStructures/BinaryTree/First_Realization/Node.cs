namespace First_Realization;


public class Node
{  
    public Node? Left {get; protected set;}

    public Node? Right {get; protected set;}

    public int Value {get; protected set;} 


    public Node(int value)
    {
        Value = value;
    }


    public static Node DescentToRight(Node node)
    {
        while (node.Right != null)
        {
            node = node.Right;
        }
        return node;
    }

    public static Node DescentToLeft(Node node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node;
    }
}

public static class NodeTools 
{
    public static void Add(this Node currentNode, Node node)
    {
        currentNode = node;
    }

    public static void Remove(this Node currentNode)
    {
        if (currentNode == null) return;
        currentNode = null;
    }
}