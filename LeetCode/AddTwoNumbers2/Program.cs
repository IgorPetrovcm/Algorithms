 namespace Program
{
    using System;
    
    class Program
    {
        public static int ReverseNum(ListNode node) 
        {
            int multiplier = 1;
            int result = 0;
            while (node != null) 
            {
                result += node.val * multiplier;
                multiplier *= 10;
                node = node.next;
            }
            return result;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            return l1;
        }
        static void Main(string[] args)
        {
            //------
            ListNode l12 = new ListNode(3);
            ListNode l11 = new ListNode(4,l12);
            ListNode l1 = new ListNode(2, l11);
            //------
            ListNode l22 = new ListNode(4);
            ListNode l21 = new ListNode(6,l22);
            ListNode l2 = new ListNode(5,l21);

            int revRes = ReverseNum(l1);
            Console.Write(revRes);
        } 
    }


    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next;
        }
  }
}
