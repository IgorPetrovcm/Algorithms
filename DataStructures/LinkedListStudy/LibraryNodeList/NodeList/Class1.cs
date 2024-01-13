using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization.Metadata;

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
    public void RemoveTail() 
    {
        Node node = head;
        while (node.next != tail) 
        {
            node = node.next;
        }
        tail = node;
        node.next = null;
    }
    public void Remove(int num) 
    {
        Node node = head;
        int count = 0;
        while (count+1 != num) 
        {
            node = node.next;
        }
        if (node.next != tail) {
            node.next = node.next.next;
        }
        else {
            tail = node;
            node.next = null;
        }
    }
    public void AddPrev(int num,int val) 
    {
        Node node = head;
        int count = 0;
        while (count+1 != num) {
            node = node.next;
        }
        Node nodeNew = new Node(val);

        if (node.next == tail) {
            node.next = nodeNew;
            nodeNew.next = tail;
        }
        else {
            nodeNew.next = node.next;
            node.next = nodeNew;
        }
        
    }
    public void AddNext(int num,int val) 
    {
        Node node = head;
        int count = 1;
        while (count != num) {
            node = node.next;
        }
        Node nodeNew = new Node(val);

        if (node == tail) {
            tail.next = nodeNew;
            tail = nodeNew;
        }
        else {
            nodeNew.next = node.next;
            node.next = nodeNew;
        }
    }
}
