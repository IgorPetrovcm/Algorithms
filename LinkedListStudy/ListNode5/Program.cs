 namespace Program
{
    using System;
    using System.Net.NetworkInformation;

    class Program
    {
        public static bool SortedInput(int input, NodeList list) 
        {
            Node node = list.head;
            while (node != null) 
            {
                if (input == node.val) return false;
                node = node.next;
            }
            return true;
        }

        static void Main(string[] args)
        {
            NodeList list = new NodeList();

            int inputSizeList = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputSizeList; i++) 
            {
                Console.WriteLine("Input value: ");
                bool output = false;
                int inputValue = 0;
                while (output == false) 
                {
                    inputValue = int.Parse(Console.ReadLine());
                    output = SortedInput(inputValue, list);
                }
                
                list.Add(inputValue);                
            }

            Node node = list.head;
            while (node != null) 
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
        }
    }
}
