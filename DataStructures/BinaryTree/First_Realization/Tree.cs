namespace First_Realization;


public class Tree
{
    public Node? Root {get; private set;}


    public void Add(int value)
    {
        Node node = new Node(value);        

        if (Root == null)
        {
            Root = node;
        }
        else 
        {
            Node currentNode = Root;

            while (currentNode.Right != node && currentNode.Left != node)
            {
                if (node.Value > currentNode.Value)
                {
                    if (currentNode.Right != null)
                    {
                        currentNode = currentNode.Right;
                    }
                    else 
                    {
                        currentNode.AddLinkToRight(node);
                    }
                }
                else
                {
                    if (currentNode.Left != null)
                    {
                        currentNode = currentNode.Left;
                    }
                    else 
                    {
                        currentNode.AddLinkToLeft(node);
                    }
                }
            }
        }
    }
}