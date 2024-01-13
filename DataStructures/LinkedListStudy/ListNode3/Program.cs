namespace  Program
{
    class Program 
    {
        public static void SortedNodeList(NodeList listMain, out NodeList listSorted1, out NodeList listSorted2) 
        {
            listSorted1 = new NodeList();
            listSorted2 = new NodeList();
            Node node = listMain.head;

            while (node != null) 
            {
                if (node.val > -1)
                {
                    listSorted1.Add(node.val);
                    node = node.next;
                }
                else if (node.val < 0) 
                {
                    listSorted2.Add(node.val);
                    node = node.next;
                }
            }
        }
        static void Main() 
        {

            int multiplier = 1;
            NodeList list = new NodeList();
            for (int i = 0; i < 5; i++) 
            {
                list.Add(i * multiplier);
                multiplier *= -1;
            }
            /*Node node = list.head;
            while (node != null) 
            {
                Console.WriteLine(node.val);
                node = node.next;
            }



            node = list.head;
            while (node != null) 
            {
                if (node.val > -1) 
                {
                    sort1.Add(node.val);
                    node = node.next;
                }
                else if (node.val < 0) 
                {
                    sort2.Add(node.val);
                    node = node.next;
                }
            } */

            NodeList sort1 ;
            NodeList sort2 ;

            SortedNodeList(list, out sort1, out sort2);
            Node node = sort1.head;
            while (node != null) 
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
            Console.WriteLine();
            node = sort2.head;
            while (node != null) 
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
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
        public NodeList() 
        {            
        }
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