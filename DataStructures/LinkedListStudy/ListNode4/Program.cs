 namespace Program
{
    using System;
    class Program
    {
        public static bool CheckList(NodeList list) 
        {
            Node node = list.head.next;
            Node node2 = list.head;
            while (node != null) 
            {
                if (node.val > node2.val) 
                {
                    node2 = node;
                    node = node.next;
                }
                else return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            NodeList list = new NodeList();

            for (int i = 0; i < 5; i++ ) 
            {
                list.Add(i);
            }
            list.Add(1);

            bool check = CheckList(list);
        }
    }

    class Node 
    {
        public int val;
        public Node next;
        public Node(int val = 0) 
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
