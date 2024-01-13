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

}