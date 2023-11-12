namespace NodeList;

public class Node
{
    public int val;
    public Node next;
    public Node(int val=0,Node next=null) 
    {
        this.val = val;
        this.next = next;
    }
}
public class NodeList 
{
    public Node head;
    public Node tail;
    public NodeList() {}

    public void Add(int val) 
    {
        Node node = new Node(val);
        if (head == null) 
        {
            head = node;
            head.next = node;
            tail = node;
            tail.next = node;
            return;
        }
        tail.next = node;
        tail = node;
    }
}
