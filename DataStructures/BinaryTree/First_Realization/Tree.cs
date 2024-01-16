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
                        currentNode.Right.Add(node);
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
                        currentNode.Left.Add(node);
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

                        current.Left.Right.Remove();

                        if (applicant.Left != null && applicant.Right != null)
                        {
                            Node nodeTailFromApplicant = Node.DescentToLeft(applicant);

                            nodeTailFromApplicant.Left.Add(current.Left);

                            nodeTailFromApplicant = Node.DescentToRight(applicant);

                            nodeTailFromApplicant.Right.Add(current.Right);                     
                        }
                        else if (applicant.Left != null && applicant.Right == null)
                        {
                            Node nodeTailFromApplicant = Node.DescentToLeft(applicant);

                            nodeTailFromApplicant.Left.Add(current.Left);   

                            applicant.Right.Add(current.Right);
                        }
                        else if (applicant.Left == null && applicant.Right != null)
                        {
                            Node nodeTailFromApplicant = Node.DescentToRight(applicant);

                            nodeTailFromApplicant.Right.Add(current.Right);

                            applicant.Left.Add(current.Left);
                        }
                        else 
                        {
                            applicant.Left.Add(current.Left);

                            applicant.Right.Add(current.Right);
                        }

                        if (rootCurrent.Left == current)
                        {
                            rootCurrent.Left.Add(applicant);
                        }                   
                        else 
                        {
                            rootCurrent.Right.Add(applicant);
                        }
                    }
                    else 
                    {
                        current.Left.Right.Add(current.Right);

                        if (rootCurrent.Left == current)
                        {
                            rootCurrent.Left.Add(current.Left);
                        }
                        else
                        {
                            rootCurrent.Right.Add(current.Left);
                        }
                    }
                    return;
                }
                else if (current.Right == null && current.Left == null)
                {
                    if (current == rootCurrent.Left)
                    {
                        rootCurrent.Left.Remove();
                    }
                    else if (current == rootCurrent.Right)
                    {
                        rootCurrent.Right.Remove();
                    }
                    else 
                    {
                        Root = null;
                    }
                }
                else if (current.Right != null)
                {
                    if (rootCurrent.Left == current)
                    {
                        rootCurrent.Left.Add(current.Right);

                        current.Right.Remove();
                    }
                    else 
                    {
                        rootCurrent.Right.Add(current.Right);

                        current.Right.Remove();
                    }
                }
                else 
                {
                    if (rootCurrent.Left == current)
                    {
                        rootCurrent.Left.Add(current.Left);

                        current.Left.Remove();
                    }
                    else 
                    {
                        rootCurrent.Right.Add(current.Left);

                        current.Left.Remove();
                    }
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

    public void CreateTreeWithArray(int[] arr)
    {
        if (Root != null)
        {
            Root = null;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Add(arr[i]);
        }
    }
}