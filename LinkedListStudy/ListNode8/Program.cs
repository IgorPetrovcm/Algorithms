namespace Program 
{
    using System;
    class Program 
    {
        public static NodeList Sorting(NodeList l1, NodeList l2) 
        {
            NodeList list = new NodeList();
            bool r = l1.GetCount() > l2.GetCount();

            if (r) 
            {
                Node node = l1.head;
                while (node != null) 
                {
                    Node node2 = l2.head;
                    while (node2 != null) 
                    {
                        if (node2.val == node.val) break;

                    }
                }
            } 
        }

        static void Main(string[] args) 
        {
            int[] arr = {2,4,8,7};
            int[] arr2 = {1,2,4,5,6};

            NodeList l1 = new NodeList();
            NodeList l2 = new NodeList();
            for (int i = 0; i < arr.Length;i++) 
            {
                l1.Add(arr[i]);
            }
            for (int i = 0; i < arr2.Length;i++) 
            {
                l2.Add(arr2[i]);
            }


        }
    }
}