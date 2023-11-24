 namespace Program
{
    using System;
    class MinStack 
    {
        int value;
        MinStack next;
        MinStack head;
        MinStack tail;
        public MinStack(int val=0) 
        {
            value = val;
        }
        public void Push(int val) 
        {
            MinStack node = new MinStack(val);
            if (head == null) 
            {
                head = node;
                head.next = node;
                tail = node;
                tail.next = node;
                return;
            }
            node.next = head;
            head = node;
            return;
        }   
        public void Pop() 
        {
            if (head == tail) {
                head.next = null;
                head = null;
                tail.next = null;
                tail = null;
                return;
            }
            head = head.next;
            return;
        }
        public int Top() 
        {
            return head.value;
        }

    }
}