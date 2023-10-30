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
        public T value {get;set;}
        public Node<T> next {get;set;}
        public Node(T value) 
        {
            this.value = value;
        }

    }
    class LinkedList<T> 
    {
        public Node<T> head {get;set;} //точка входа
        public Node<T> tail {get;set;} //конечный элемент
        public int length {get;set;} //количество элементов


        public void Add(T value) 
        {
            Node<T> node = new Node<T>(value);

            if (head == null){
                head = node;
            }
            else {
                tail!.next = node;
            }
            tail = node;

            length++;
        }
        public bool Remove(T value) 
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null && current.value != null) 
            {
                if (current.value.Equals(value)) 
                {
                    if (previous != null) 
                    {
                        previous.next = current.next;

                        if (current.next == null)
                        {
                            tail = previous;
                        }
                    }
                    else 
                    {
                        head = head.next;

                        if (head == null) 
                        {
                            tail = null;
                        }
                    }
                    length--;
                    return true;
                }
                previous = current;
                current = current.next;
            }
            return false;
        }
    }
}
