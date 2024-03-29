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
        }
    }
    class NodeList 
    {
        public Node head;
        public Node tail;
        public NodeList() {}
        public void Add(int val) 
        {
            Node node = new Node(val);

            if (head==null) 
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
        public int GetCount() 
        {
            int count = 0;
            Node node = head;
            while (node != null) 
            {
                count++;
                node = node.next;
            }

            return count;
        }
    }
}