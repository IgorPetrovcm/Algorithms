 namespace Program
{
    using System;
    using NodeList;
    class Program
    {
        public static NodeList Sorted(int q, int x, NodeList l1) 
        {
            int count = 1;
            Node node = l1.head;
            while (node != null) 
            {
                if (count != q) 
                {
                    count++;
                    node = node.next;
                    continue;
                }
                if (node == l1.tail) l1.Add(x);
                Node node2 = new Node(x);
                node2.next = node.next;
                node.next = node;
                return l1;
            }
            return l1;
        }
        static void Main(string[] args)
        {
            int q = 3;
            int x = 12;
            NodeList l1 = new NodeList();
            Random rand = new Random();
            for (int i = 0; i < 6; i++) 
            {
                l1.Add(rand.Next(1,8));                
            }
            Node node = l1.head;
            while (node != null) 
            {
                Console.Write(node.val);
                node = node.next;
            }
            Console.WriteLine();
            l1 = Sorted(q,x,l1);

            node = l1.head;
            while (node != null) 
            {
                Console.Write(node.val);
                node = node.next;
            }
        }
    }
}
