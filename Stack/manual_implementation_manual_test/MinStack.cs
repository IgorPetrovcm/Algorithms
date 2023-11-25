 namespace Program
{
    using System;
    using System.ComponentModel;

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
                tail.next = null;
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
        public int getMin() 
        {
            MinStack stack = head;            
            List<int> list = new List<int>();
            while (stack.next != null) 
            {
                list.Add(stack.value);
                stack = stack.next;
            }
            int[] arr = new int[list.Count()];
            int i = 0;
            foreach (int l in list) 
            {
                arr[i] = l;
                i++;
            }
            
            Array.Sort(arr);
            return arr[0];
        }

    }
}