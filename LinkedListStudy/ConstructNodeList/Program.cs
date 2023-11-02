namespace Program 
{
    using System;
    class Program 
    {
        static void Main(string[] args) 
        {
            ListNode list = new ListNode();
            list.Add(5);
            list.Add(2);
            list.Add(3);
            bool remove = list.Remove(3);
            bool search = list.Search(6);
        }
    }

    class Node 
    {
        public int val;
        public Node next;
        public Node(int val) 
        {
            this.val = val;
        }
    }

    class ListNode 
    {
        Node head;
        Node tail;

        public void Add(int val) 
        {
            Node node = new Node(val);
            if (head == null) 
            {
                head = node;
                tail = head;
                return;
            }
            tail.next = node;
            tail = tail.next;
        }
        public bool Search(int val) 
        {
            Node node = head;
            while (node.val != val) 
            {
                if (node.next == null) return false;
                node = node.next;
            }
            return true;
        }
        public bool Remove(int val) 
        {
            Node node = head;
            while (node.val != val) 
            {
                if (node.next == null) return false;
                if (node.next.val == val) 
                {
                    if (node.next == tail) {
                        tail.next = node;
                        tail = node;
                        return true;
                    }
                    else {
                        node.next = node.next.next;
                        return true;
                    }
                }  
                node = node.next;              
            }
            return true;

        } 
    }
}