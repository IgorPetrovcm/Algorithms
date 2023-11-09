namespace BinarySearch4 
{
    using System;
    using System.IO;
    using System.Net.NetworkInformation;

    class Program 
    {
        static void Main(string[] args) 
        {
            string path = @"/home/admin/Общедоступные/csStudy/Algorithms/BinarySearch4/TestRead.txt";
            StreamReader reader = new StreamReader(path);
            
            string line;
            string text = null;
            while ((line = reader.ReadLine()) != null) 
            {
                text += "\n" + line;
            }

            Console.WriteLine(text);
        }
    }
}