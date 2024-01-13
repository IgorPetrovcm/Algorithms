namespace BinarySearch 
{
    using System;
    class Program 
    {
        static void Main(string[] args) 
        {
            int[] array = new int[9];
            for (int i = 0; i < array.Length;i++) 
            {
                array[i] = i+1;
            }

            int low = 0;
            int hight = array.Length;

            int val = 0;
            int index;

            int inputSearch = int.Parse(Console.ReadLine());

            while (low <= hight) 
            {
                index = (low + hight) / 2;
                val = array[index];
                Console.WriteLine(val);

                if (val == inputSearch) {
                    Console.WriteLine(val);
                    return;
                }
                else if (val > inputSearch) {
                    hight = index - 1;
                }
                else {
                    low = index + 1;
                }
            }

        }
    }
}