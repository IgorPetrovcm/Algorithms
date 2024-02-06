using System.Text;

namespace NodeListLib;

public class NodeList<T>
{
    
    public Node<T> Head {get; private set;}

    public Node<T> Tail {get; private set;}

    public int Count { get; private set;}

    public override string ToString() 
    {
        StringBuilder output = new StringBuilder();

        Node<T> node = Head;

        while (node != null)
        {
            output.Append(node.Value + "\n");
            node = node.Next;
        }

        return output.ToString();
    }

    public void Add(T value)
    {
        Node<T> node = new Node<T>(value);
        if (Head == null)
        {
            Head = node;

            Head.AssignNext(node);

            Tail = node;

            Count++;

            return;
        }

        Tail.AssignNext(node);

        Tail = node;
        
        Count++;
    }

    public void Remove(T value)
    {
        if (Head == null) throw new NullReferenceException("List values does not exist");

        Node<T> node = Head;

        Node<T>? prev = null;

        while (node !=  null)
        {
            if (node.Value.Equals(value))
            {
                if (node == Tail){
                    prev.AssignNext(null);

                    Tail = prev;

                    Count--;

                    return;
                }
                if (node == Head)
                {
                    Head = node.Next;

                    Count--;

                    return;
                }

                prev.AssignNext(node.Next);

                Count--;

                return;
            }
            prev = node;
            
            node = node.Next;
        }
        return;
    }

    public static NodeList<T> UploadUsingEnumerable(IEnumerable<T> elements)
    {
        if (elements == null) throw new NullReferenceException("Upload struct is empty");

        NodeList<T> nodes = new NodeList<T>();

        foreach (var element in elements)
        {
            nodes.Add(element);
        }

        return nodes; 
    }

}