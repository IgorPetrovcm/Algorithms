namespace Program
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /*int val1;
            int number = 5308;

            val1 = number % 10;
            val1 /= 1;
            System.Console.WriteLine(val1); 

            val1 = number % 100;
            System.Console.WriteLine(val1);
            val1 /= 10;
            System.Console.WriteLine(val1);

            val1 = number % 1000;
            val1 /= 100;
            System.Console.WriteLine(val1);

            val1 = number % 10000;
            val1 /= 1000;
            System.Console.WriteLine(val1);

            val1 = number % 100000;
            System.Console.WriteLine(val1);
            val1 /= 10000;
            System.Console.WriteLine(val1);*/

            //Это не работает... и можно проще!

            //способ
            //схема храниться в папке под названием 'Sheme1.txt'
            int value = 1234;

            int current = value;
            int reverseCurrent = 0;

            while (current > 0) 
            {
                int unit = current % 10; // 1: 123 -> 4
                current = current / 10; // 1: 123 -> -4
                reverseCurrent = reverseCurrent * 10 + unit;
            }

            Console.WriteLine(reverseCurrent);
        }
    }
}
