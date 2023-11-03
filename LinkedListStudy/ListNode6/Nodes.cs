 namespace Program
{
    using System;
    class Node 
    {
        public int val;
        public Node next;
        public Node(int val)
        {
            this.val = val;
            next = null;
        }
    }
    class NodeList 
    {
        public Node head;
        public Node tail;
        public NodeList() { head = null;
        tail = null; }
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
}
