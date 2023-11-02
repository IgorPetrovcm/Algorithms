 namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,13,5};
            int[] arr2 = new int[2];
            int n = 39;

            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = i; j < arr.Length; j++) 
                {
                    if (arr[i] + arr[j] == n) {
                        arr2[0] = arr[i];
                        arr2[1] = arr[j];

                        foreach (int a in arr2) Console.Write($"{a} ");
                    } 
                }
            }

        }
    }
}
