 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Node<T>
    {
        public int val;
        public Node<T> next;

        public Node(int val = 0, Node<T> next = null)
        {
            this.next = next;
            this.val = val;
        }
    }
    class ListNode<T> 
    {
        Node<T> head;
        Node<T> tail;

        public void Add(int val) 
        {   
            Node<T> node = new Node<T>(val);
            if (head == null) 
            {
                head.next = node;
                head = node;
                tail.next = node;
                tail = node;    
                return;        
            }
            tail.next = node;
            tail = node;
        }
        //Задание реализации подсчета действительных чисел
        public int Counting1() 
        {
            int count = 0;
            Node<T> node = head;
            while (node.next != null) 
            {
                count++;
            }
            return count;
        }
    }
}
