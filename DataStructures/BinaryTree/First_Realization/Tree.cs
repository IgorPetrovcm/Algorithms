using System.Globalization;

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

    public void Remove(int value)
    {
        Node rootCurrent = null;

        Node current = Root;

        while (current != null)
        {
            if (value == current.Value)
            {
                if (current.Right != null && current.Left != null)
                {
                    if (current.Left.Right != null)
                    {
                        Node applicant = current.Left.Right;

                        current.Left.RemoveRightLink();

                        if (applicant.Left != null && applicant.Right != null)
                        {
                            Node nodeTailFromApplicant = Node.DescentToLeft(applicant);

                            nodeTailFromApplicant.AddLinkToLeft(current.Left);

                            nodeTailFromApplicant = Node.DescentToRight(applicant);

                            nodeTailFromApplicant.AddLinkToRight(current.Right);                     
                        }
                        else if (applicant.Left != null && applicant.Right == null)
                        {
                            Node nodeTailFromApplicant = Node.DescentToLeft(applicant);

                            nodeTailFromApplicant.AddLinkToLeft(current.Left);   

                            applicant.AddLinkToRight(current.Right);
                        }
                        else if (applicant.Left == null && applicant.Right != null)
                        {
                            Node nodeTailFromApplicant = Node.DescentToRight(applicant);

                            nodeTailFromApplicant.AddLinkToRight(current.Right);

                            applicant.AddLinkToLeft(current.Left);
                        }
                        else 
                        {
                            applicant.AddLinkToLeft(current.Left);

                            applicant.AddLinkToRight(current.Right);
                        }

                        if (rootCurrent.Left == current)
                        {
                            rootCurrent.AddLinkToLeft(applicant);
                        }                   
                        else 
                        {
                            rootCurrent.AddLinkToRight(applicant);
                        }
                    }
                    else 
                    {
                        current.Left.AddLinkToRight(current.Right);

                        if ()
                    }
                    return;
                }
                else if (current.Right == null && current.Left == null)
                {
                    if (current == rootCurrent.Left)
                    {
                        rootCurrent.RemoveLeftLink();
                    }
                    else if (current == rootCurrent.Right)
                    {
                        rootCurrent.RemoveRightLink();
                    }
                    else 
                    {
                        Root = null;
                    }
                }
                else if (current.Right != null)
                {
                    rootCurrent.AddLinkToRight(current.Right);

                    current.RemoveRightLink();
                }
                else 
                {
                    rootCurrent.AddLinkToRight(current.Left);

                    current.RemoveLeftLink();
                }
                return;
            }
            else
            {
                rootCurrent = current;

                if (value > current.Value)
                {
                    current = current.Right;
                }
                else 
                {
                    current = current.Left;
                }
            }
        }
    }
}