namespace  Program
{
    class Program 
    {
        public static void SortNodeList(NodeList list, out NodeList listSort1, out NodeList listSort2) 
        {
            listSort1 = new NodeList(); 
            listSort2 = new NodeList();

            Node node = list.head;
            while (node.next != null) 
            {
                if (node.val > -1) 
                {
                    listSort1.Add(node.val);
                    node = node.next;
                }
                if (node.val < 0) 
                {
                    listSort2.Add(node.val);
                    node = node.next;
                }
                
            } 
        }
        static void Main() 
        {
            int multiplier = 1;   

            NodeList list = new NodeList();
            for (int i = 0; i < 6; i++ ) 
            {
                list.Add(i * multiplier);
                multiplier *= -1;
            } 

            NodeList sort1 ;
            NodeList sort2 ;
            SortNodeList(list,out sort1, out sort2);

            Node node = list.head;
            for (int i = 0; i < 6; i++) 
            {
                Console.Write($"{node.val} ");
                node = node.next;
            }
            Console.WriteLine();

            node = sort1.head;
            while (node.next != null) 
            {
                Console.Write($"{node.val} ");
                node = node.next;
            }
            Console.WriteLine();

            node = sort2.head;
            while (node.next != null) 
            {
                Console.Write($"{node.val} ");
                node = node.next;
            }
        }
    }
    class Node 
    {
        public int val;
        public Node next;
        public Node(int val = 0, Node next = null) 
        {
            this.val = val;
            this.next = next;
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
            tail = node;
            tail.next = node;

        }
    }
}