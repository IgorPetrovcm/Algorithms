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
        public static ListNode Nodes(int sum, int length) 
        {
            if (length == 0) return null;
            ListNode node = new ListNode();
            int unit = sum % 10;
            sum /= 10;
            node.val = unit;
            length -= 1;
            node.next = Nodes(sum,length);
            return node;
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
        {
            int sum = ReverseNum(l1) + ReverseNum(l2);
            ListNode sumNode = Nodes(sum,sum.ToString().Length);            
            return sumNode;

        }
        static void Main(string[] args)
        {
            //------
            //ListNode l12 = new ListNode(3);
            //ListNode l11 = new ListNode(4,l12);
            ListNode l1 = new ListNode(0);
            //------
            //ListNode l22 = new ListNode(4);
            //ListNode l21 = new ListNode(6,l22);
            ListNode l2 = new ListNode(0);

            ListNode list = AddTwoNumbers(l1,l2);

            while (list != null) 
            {
                Console.Write(list.val + " ");
                list = list.next;
            }
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
