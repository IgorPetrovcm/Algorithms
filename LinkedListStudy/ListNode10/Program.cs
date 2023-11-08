namespace Program 
{
    using System;
    class Program 
    {
        public static NodeList CreateNewList(NodeList l1) 
        {
            int addVal = 0;
            NodeList list = new NodeList();
            Node node = l1.head;
            while (node != null) 
            {
                if (node.val != addVal) 
                {
                    addVal = node.val;
                    list.Add(addVal);
                    node = node.next;
                    continue;
                }
                node = node.next;
            } 
            return list;
        }
        static void Main(string[] args) 
        {
            int[] arr = {1,2,2,4,7,8,8,8,3};
            NodeList l1 = new NodeList();
            l1.AddFromArray(arr);

            NodeList list = CreateNewList(l1);
            Node node = list.head;
            while (node != null) 
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
        } 
    }
}