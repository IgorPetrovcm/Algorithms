 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i < 6; i++) 
            {
                queue1.Enqueue(i);
                queue2.Enqueue(i);
            }

            for (int i= 0; i < 5; i++) 
            {
                queue.Enqueue(queue1.Dequeue());
                queue.Enqueue(queue2.Dequeue());                
            }
            foreach (var unit in queue) 
            {
                System.Console.WriteLine(unit);
            }
        }
    }
}