 namespace Program
{
    using System;
    using System.Formats.Asn1;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {3,5,1};
            int[] arr2 = {1,4,7};
            int[] arr3 = {6,3,0};

            //O(n) изначально было без Array.Sort, поэтому работало не правильно, массив не был отсортирован. Для Sort код сложный и плохой
            /*Array.Sort(arr);
            int abs = 0;
            if (1 < arr.Length) 
            {
                abs = Math.Abs(arr[0] - arr[1]);
            }

            for (int i = 1; i < arr.Length; i++) 
            {
                if (i+1 < arr.Length) 
                {
                    if (Math.Abs(arr[i] - arr[i+1]) == abs) continue;
                    else { 
                        Console.WriteLine("false"); 
                        return;
                    }
                }
                else break;

            }
            Console.WriteLine("true"); */

            //O(n)?
            Array.Sort(arr);

            int abs = 0;
            if (1 < arr.Length) {
                abs = arr[0] - arr[1];
            }
            //else return true;
            for (int i = 1; i < arr.Length - 1; i++) 
            {
                if (arr[i] - arr[i+1] != abs) Console.Write("false");
            }
            Console.Write("true");
        }
    }
}
