namespace AddTwoNumbers  
{ 
    class Program  
    { 
        public static int GetValues(ListNode list)  
        { 
            ListNode node = list; 
            string values = ""; 
            while (true)  
            { 
                values += node.val; 
                if (node.next == null) break; 
                node = node.next; 
            } 
            values = GetReverseVal(values); 
            return int.Parse(values); 
        }  
        public static string GetReverseVal(string val)  
        { 
            string reverseVal = ""; 
            for (int i = val.Length-1; i!=-1; i--)  
            { 
                reverseVal += val[i];  
            } 
            return reverseVal; 
        } 
        static void Main(string[] args)  
        { 
            ListNode l02 = new ListNode(3,null); 
            ListNode l01 = new ListNode(4,l02); 
            ListNode l1 = new ListNode(2,l01); 
 
            ListNode l22 = new ListNode(4,null); 
            ListNode l21 = new ListNode(6,l22); 
            ListNode l2 = new ListNode(5,l21); 
 
            int val1 = GetValues(l1); 
            int val2 = GetValues(l2); 
 
            int sum = val1+val2;
            string reversSum = GetReverseVal(sum.ToString()); 
 
            int i = 0; 
            ListNode ls = new ListNode(int.Parse(reversSum[0].ToString()) , AddNode(i,reversSum,reversSum.Length)); 
 
            while (true)  
            { 
                System.Console.WriteLine(ls.val); 
                if (ls.next == null) break; 
                ls = ls.next; 
            } 
        } 
        public static ListNode AddNode(int i, string sum, int length)  
        { 
            i++; 
            if (i == length)  
            { 
                return null; 
            } 
            ListNode ls = new ListNode(int.Parse(sum[i].ToString()) , AddNode(i,sum,sum.Length)); 
            return ls; 
        } 
    } 
 
    public class ListNode  
    { 
        public int val; 
        public ListNode next; 
        public ListNode(int val, ListNode next) { 
            this.val = val; 
            this.next = next; 
        } 
    } 
}