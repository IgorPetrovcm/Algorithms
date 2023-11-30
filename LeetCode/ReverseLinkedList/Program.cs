namespace Program;
class Program 
{
    static void Main() 
    {
        /*ListNode node5 = new ListNode(5);
        ListNode node4 = new ListNode(4,node5);
        ListNode node3 = new ListNode(3,node4);
        ListNode node2 = new ListNode(2);*/
        ListNode head = new ListNode();

        ListNode node = new ListNode(head.val);
        while (head.next != null) 
        {
            head = head.next;
            node =new ListNode(head.val, node);
        } 

        while (node != null) {
            System.Console.WriteLine(node.val);
            node = node.next;
        }
    }
}
public class ListNode {
     public int val;
     public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
         this.val = val;
         this.next = next;
    }
}