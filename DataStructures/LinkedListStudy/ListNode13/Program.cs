namespace ListNode 
{
	using System;
	class Program 
	{
        public static NodeList Sotring(NodeList l1) 
        {
            Node node = l1.head;
            while (node.next != null) 
            {
                node.next.val = node.val + node.next.val;
                node = node.next; 
            }
            return l1;
        }
		static void Main(string[] args) 
		{
            NodeList l1 = new NodeList();
            Random rand = new Random();
            for (int i = 0; i < 5; i++) 
            {
                l1.Add(rand.Next(1,8));
            }
            Node node = l1.head;
            while (node != null) 
            {
                Console.Write(node.val);
                node = node.next;
            }
            l1 = Sotring(l1);            
            node = l1.head;
            Console.WriteLine();
            while (node != null) 
            {
                Console.Write(node.val);
                node = node.next;
            }

		}
	}
}