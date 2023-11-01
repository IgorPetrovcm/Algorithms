namespace Program
{
    using System;
    using System.Security.AccessControl;
    using Microsoft.VisualBasic;

    class Program
    {
        static void Main(string[] args)
        {
            /*Random rand = new Random();
            int[] arr = new int[rand.Next(0,20)];

            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] = rand.Next(0,100000);
                Console.Write($"{arr[i]}  ");
            }*/
            int[] arr = new int[] {33, 68, 400, 5};

            
            for (int i = 0; i < arr.Length; i++)
            {
                int remainderMultiplier = 10;
                int integerMultiplier = 1;

                int val = 0;

                int count = 0;
                int numberLength = arr[i].ToString().Length;
                while (count != numberLength) 
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
                    
                    count++;
                }
            }
            Console.WriteLine("there is no 7 in the array");
        }

    }
}
