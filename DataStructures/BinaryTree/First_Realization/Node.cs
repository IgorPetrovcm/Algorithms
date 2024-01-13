namespace First_Realization;


public class Node
{
    public Node? Left {get; private set;}

    public Node? Right {get; private set;}

    public int Value {get; private set;} 


    public Node(int value)
    {
        Value = value;
    }


    public void AddLinkToRight(Node node)
    {
        Right = node;
    }
    public void AddLinkToLeft(Node node)
    {
        Left = node;
    }

    public void RemoveLeftLink()
    {
        Left = null;
    }
    public void RemoveRightLink()
    {
        Right = null;
    }

    public static Node DescentToLeft(Node node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }
        return node;
    }

    public static Node DescentToRight(Node node)
    {
        while (node.Right != null)
        {
            node = node.Right;
        }
        return node;
    }



}