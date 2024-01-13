namespace Program 
{
    public class Node 
    {
        public int val;
        public Node next;
        public Node(int val=0,Node next=null) 
        {
            this.val = val;
            this.next = next; 
        }
    }
    public class NodeList 
    {
        public Node head;
        public Node tail;

        public NodeList() {}
        public void Add(int val) 
        {
            Node node = new Node(val);
            if (head == null) 
            {
                head = node;
                head.next = node;
                tail = node;
                tail.next = node;
                return;
            }
            tail.next = node;
            tail = node;
        }
        public void AddFromArray(int[] arr) 
        {
            for (int i = 0; i < arr.Length;i++) 
            {
                Node node = new Node(arr[i]);
                if (head == null) {
                    head = node;
                    head.next = node;
                    tail = node;
                    tail.next = node;
                }
                tail.next = node;
                tail = node; 
            }
        }

    }
}