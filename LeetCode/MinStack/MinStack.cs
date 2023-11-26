namespace Program 
{
    using System; 
    public class StackElement 
    {
        public int val; 
        public StackElement next;
        public StackElement(int val=0, StackElement next=null) {
            this.val = val; 
            this.next = next;
        }
    }
    public class MinStack 
    {
        StackElement head;
        public MinStack() {}
        public void Push(int val) 
        {
            StackElement element = new StackElement(val);
            if (head == null) {
                head = element;
                return;                
            }
            element.next = head;
            head = element;            
        }
        public void Pop() 
        {               
            head = head.next;            
        }
        public int Top() 
        {
            return head.val;
        }
        public int GetMin() 
        {
            int valMin = head.val;            
            MinStack stack  = new MinStack();
            stack.Push(valMin);
            StackElement element = head.next;
            while (element != null) {
                if (element.val < valMin) {
                    stack.Push(element.val);
                    valMin = element.val;
                }
                element = element.next;
            }

            return stack.Top();
        }
    }
}