 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            int[] arr = {1,1,1,3,7,2,2,5,5};
            for (int i =  0; i < arr.Length; i++) 
            {
                queue.Enqueue(arr[i]);
                System.Console.WriteLine(arr[i]);
            }

            for (int i =0; i < arr.Length; i++) 
            {
                System.Console.WriteLine(queue.Peek());
                if (queue.Peek() % 2 == 0) return;
                queue.Dequeue();
            }
        }
    }
}