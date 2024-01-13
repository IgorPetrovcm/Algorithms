 namespace Program
{
    using System;
    using System.Net;

    class Program
    {
        public static NodeList SortingList(NodeList list)
        {
            NodeList sort = new NodeList();
            Node node = list.head;            

            while (node.next != null) 
            {
                sort.Add(node.val);
                if (node.next.val % 2 == 0) 
                {
                    sort.Add(node.next.val);
                    Node newnode = node.next;
                    if (node.next.next != null) 
                    {                        
                        node.next = newnode; 
                        node = node.next;
                        continue;
                    }
                    else 
                    {
                        list.tail = newnode;
                        node.next = newnode;
                        continue;
                    }
                   
                }
                node = node.next;
            }
            sort.Add(list.tail.val);
            return sort;
        }

        static void Main(string[] args)
        {
            NodeList list = new NodeList();
            for (int i = 0; i < 8; i++) 
            {
                list.Add(i);
            }

            NodeList sort = SortingList(list);
            Node node = sort.head;
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }

        }
    }
}
