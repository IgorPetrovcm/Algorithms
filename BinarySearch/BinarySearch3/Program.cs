namespace BinarySearch3 
{
    using System;
    class Program 
    {
        static void Main(string[] args) 
        {
            Random rand = new Random();
            byte sizeZero = (byte)rand.Next(0,10);
            byte sizeOne = (byte)rand.Next(0,10);

            byte[] arr = new byte[(byte)(sizeZero + sizeOne)];

            for (int i = 0; i < sizeZero;i++){
                arr[i] = 0;
                Console.Write(arr[i] + " ");
            }
            for (int i = sizeZero; i < arr.Length;i++){
                arr[i] = 1;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            short length = -1;
            byte right = (byte)arr.Length;

            while ((right - length) != 1) 
            {
                byte index = (byte)((right + length)/2);

                if (arr[index] == 0) {
                    length = index;
                }
                else {
                    right = index;
                }
            } 
            Console.WriteLine(length + " " + right);
            Console.WriteLine(arr[length] + " " + arr[right]);
        }
    }
}