namespace Program
{
    using System;
    using System.Security.AccessControl;
    using Microsoft.VisualBasic;

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

            int remainderMultiplier = 10;
            int integerMultiplier = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                int val = 0;
                while (val != arr[i]) 
                {
                    val = arr[i] % remainderMultiplier;
                    val /= integerMultiplier;
                    if (val == 7) 
                    {
                        Console.WriteLine("Boom!");
                        return;
                    } 
                    remainderMultiplier *= 10;
                    integerMultiplier *= 10;
                }
            }
            Console.WriteLine("there is no 7 in the array");
        }

    }
}
