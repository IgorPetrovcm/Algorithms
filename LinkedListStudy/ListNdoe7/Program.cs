namespace ListNode7 
{
    using System;
    using System.Runtime.CompilerServices;

    class Program 
    {
        public static NodeList Merge(NodeList l1,NodeList l2) 
        {
            NodeList list = new NodeList();
            Node node1 = l1.head;
            Node node2 = l2.head;
            while (true) 
            {
                if (node1 == null && node2 == null) return list;
                if (node1 == null) 
                {
                    list.Add(node2.val);
                    node2 = node2.next;
                }
                if (node2 == null) 
                {
                    list.Add(node1.val);
                    node1 = node1.next;
                }
                list.Add(node1.val);
                list.Add(node2.val);
                node1 = node1.next;
                node2 = node2.next;
            }
        }
        static void Main(string[] args) 
        {
            NodeList l1 = new NodeList();
            NodeList l2 = new NodeList();
            for (int i = 0; i < 5; i++) 
            {
                l1.Add(i);
                l2.Add(i+1);
            }

            NodeList list = Merge(l1,l2);
            
            Node node = list.head;
            while (node != null) 
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
        }
    }
}