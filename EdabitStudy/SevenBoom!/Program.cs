namespace Program
{
    using System;
    using System.Security.AccessControl;

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[rand.Next(0,20)];

            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = rand.Next(0,100000);
                Console.Write($"{arr[i]}  ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int remainder;
                while ()

            }
        }
    }
}
