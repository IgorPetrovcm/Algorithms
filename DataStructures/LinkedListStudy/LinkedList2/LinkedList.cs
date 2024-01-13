namespace Program;
public class Node<T> 
{
    public T value;
    public Node<T> next;
    public Node<T> prev;
    public Node(T value, Node<T> next, Node<T> prev) 
    {
        this.value = value;
        this.next = next;
        this.prev = prev;
    }
    public Node() 
    {
        value = default(T);
        next = null;
        prev = null;
    }
    public Node(T value) 
    {
        this.value = value;
        next = null;
        prev = null; 
    }
}
public class LinkedList<T> 
{
    public Node<T> head;
    public Node<T> tail;
    public LinkedList() {}

    public void Add(T value) 
    {
        Node<T> node = new Node<T>(value);
        if (head == null) 
        {
            head = node;
            tail = node;
            return;
        }
        tail.next = node;
        tail.prev = tail;
        tail = node;

    }   
    public void AddToBegin(T value) 
    {
        Node<T> node = new Node<T>(value);
        if (head == null) {
            Add(value); return;
        } 
        head.prev = node;
        node.next = head;
        head = node;
    }
}