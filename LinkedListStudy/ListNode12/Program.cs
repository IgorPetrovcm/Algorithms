namespace ListNode 
{
	using System;
	class Program 
	{
        public static NodeList Sorting(NodeList l1) 
        {
            int countError = 0;            
            while (true) 
            {   
                countError = 0;
                Node node = l1.head;
                while (node.next != null) 
                {
                    if (node.val > node.next.val) {
                        int val = node.next.val;
                        node.next.val = node.val;
                        node.val = val;
                        node = node.next;
                        countError++;
                        continue;
                    }
                    node = node.next;
                }
                if (countError == 0) return l1;                
            }
        }
		static void Main(string[] args) 
		{
            Random rand = new Random();
            NodeList l1 = new NodeList();
			for (int i = 0; i < 4; i++) 
            {
                l1.Add(rand.Next(-5,8));
            }

            NodeList list = Sorting(l1);
            Node node = list.head;
            while (node != null) 
            {
                Console.Write(node.val);
                node = node.next;
            }
		}
	}
}