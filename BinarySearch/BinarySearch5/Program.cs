 namespace Program
{
    using System;
    using System.Globalization;

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,3,3,4,6,7,7,12};
            int searchValue = 5;
            int head = 0;
            int tail = arr.Length-1;
            while (head + 1 != tail) 
            {
                int value = (head + tail) /2;
                if (arr[value] > searchValue) tail = value;
                else head = value; 
            }
            Console.Write(arr[head] + " " + arr[tail]);
        }
    }
}
